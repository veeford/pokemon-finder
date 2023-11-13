using Microsoft.EntityFrameworkCore;
using PokemonWeb;

public class Fight
{
    int pokemonPlayerHp;
    int pokemonPlayerAttack;
    int pokemonCpuHp;
    int pokemonCpuAttack;
    int pokemonPlayerId;
    int pokemonCpuId;
    int rounds;

    public int Rounds { get {return rounds;} set { rounds = value; }}
    public int PokemonPlayerHp { get { return pokemonPlayerHp; }}
    public int PokemonCpuHp { get { return pokemonCpuHp; }}

    public Fight(Pokemon player, Pokemon cpu)
    {
        pokemonPlayerHp = player.HP;
        pokemonPlayerAttack = player.Attack;
        pokemonCpuHp = cpu.HP;
        pokemonCpuAttack = cpu.Attack;
        pokemonPlayerId = player.Id;
        pokemonCpuId = cpu.Id;
        rounds = 0;
    }

    public Fight()
    {
        rounds = -1;
    }

    public (bool, bool) Step(int playerNum, int cpuNum)
    {
        rounds++;
        bool isPlayerOrder = playerNum % 2 == 0 && cpuNum % 2 == 0;
        if (isPlayerOrder)
        {
            // Player
            pokemonCpuHp -= pokemonPlayerAttack;
        }
        else
        {
            // CPU
            pokemonPlayerHp -= pokemonCpuAttack;
        }

        if (!(pokemonCpuHp > 0 && pokemonPlayerHp > 0))
        {
            int winner, loser;
            if (pokemonCpuHp <= 0)
            {
                // Player won
                winner = pokemonPlayerId;
                loser = pokemonCpuId;
            }
            else
            {
                // CPU won
                winner = pokemonCpuId;
                loser = pokemonPlayerId;
            }

            // writing results into DB (datetime, winner_id, loser_id, rounds_count)
            try
            {
                using (PokemonFightContext db = new PokemonFightContext())
                {
                    FightsLog log = new FightsLog
                    {
                        FightDatetime = DateTime.Now,
                        WinnerId = winner,
                        LoserId = loser,
                        RoundsCount = rounds
                    };
                    db.Add(log);
                    db.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                
            }
        }

        return (pokemonCpuHp > 0 && pokemonPlayerHp > 0, isPlayerOrder);
    }

    public async Task<FightsLog> Fast()
    {
        Random rnd = new Random();
        while (pokemonCpuHp > 0 && pokemonPlayerHp > 0)
        {
            rounds++;
            int cpuNum1 = rnd.Next(1, 10);
            int cpuNum2 = rnd.Next(1, 10);
            bool isPlayerOrder = cpuNum1 % 2 == 0 && cpuNum2 % 2 == 0;
            if (isPlayerOrder)
            {
                // CPU 1
                pokemonCpuHp -= pokemonPlayerAttack;
            }
            else
            {
                // CPU 2
                pokemonPlayerHp -= pokemonCpuAttack;
            }
        }

        int winner, loser;
        if (pokemonCpuHp <= 0)
        {
            // CPU 1 won
            winner = pokemonPlayerId;
            loser = pokemonCpuId;
        }
        else
        {
            // CPU 2 won
            winner = pokemonCpuId;
            loser = pokemonPlayerId;
        }
        FightsLog log = new FightsLog
        {
            FightDatetime = DateTime.Now,
            WinnerId = winner,
            LoserId = loser,
            RoundsCount = rounds
        };

        // writing results into DB (datetime, winner_id, loser_id, rounds_count)
        using (PokemonFightContext db = new PokemonFightContext())
        {
            db.Add(log);
            db.SaveChanges();
        }

        return log;
    }

    public async Task SendFightEmailAsync(FightsLog log, string email)
    {
        // sending e-mail
        string message = $"<b>Fight:</b><br>Fight date & time: {log.FightDatetime}<br>Winner ID: {log.WinnerId}<br>Loser ID: {log.LoserId}<br>Rounds: {log.RoundsCount}";
        EmailService emailService = new EmailService();
        await emailService.SendEmailAsync(email, "Pokemon FAST FIGHT", message);
    }
}