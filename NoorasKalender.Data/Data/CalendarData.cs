using NoorasKalender.Common.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoorasKalender.Data.Data;

public class CalendarData : IData
{
    private readonly List<Riddle> _riddles = new()
        {
            new Riddle{
            Id = 1,
            Question = "En växt som är ej törstig, i plast så fint och kär,\r\ni denna kruka, din gåva väntar där.",
            AnswersId = 1
        },
            new Riddle{
                Id = 2,
                Question = "Ett spel som passar för alla, ung som gammal i varje lag,\r\ngul, röd, grön, blå – brukar vara Hilmars första förslag.",
                AnswersId = 2
            },
            new Riddle{
                Id = 3,
                Question = "På isen jag svävar, lätt och fin,\r\ni vinterns dans, med stål som min.",
                AnswersId = 3
            },
            new Riddle{
                Id = 4,
                Question = "I hörnet jag vilar, med strängar klara,\r\nväntar på att spelas, vem kan jag vara?",
                AnswersId = 4
            },
            new Riddle{
                Id = 5,
                Question = "Jag reflekterar ditt leende, i ditt rum jag stilla står,\r\nSom mamma säger, le mot mig så du bättre mår.",
                AnswersId = 5
            },
            new Riddle{
                Id = 6,
                Question = "Från Island, ett minne, tyst i vårt hem,\r\nett konstverk så fint, skapat av familjen.",
                AnswersId = 6
            },
            new Riddle{
                Id = 7,
                Question = "I mörkt och svalt, de vilar där,\r\nväntar på kvällen, för att dela sin juice av bär.",
                AnswersId = 7
            },
            new Riddle{
                Id = 8,
                Question = "På golvet den vilar, mjuk och bred,\r\nFrån Högdalen den fick följa med.",
                AnswersId = 8
            },
            new Riddle{
                Id = 9,
                Question = "Med visare tickar tyst i sin gång,\r\npå väggen den hänger, i tidens sång.",
                AnswersId = 9
            },
            new Riddle{
                Id = 10,
                Question = "I köket jag gömmer mig, för att undvika brand,\r\nnär hetta blir till, jag är till för att skydda din hand.",
                AnswersId = 10
            },
            new Riddle{
                Id = 11,
                Question = "Här ligger jag, i lådan i min ro,\r\nnär det börjar bli mörkt, mina grannar du snor.",
                AnswersId = 11
            },
            new Riddle{
                Id = 12,
                Question = "I lådan där trosor i högar sig gömmer,\r\nbland oanvända stringar, min hemlighet drömmer.",
                AnswersId = 12
            },
            new Riddle{
                Id = 13,
                Question = "Där studier flödar, och tankarna klaras,\r\npå mitt bord, där vår framtid formas och jagas.",
                AnswersId = 13
            },
            new Riddle{
                Id = 14,
                Question = "I bildernas värld, där seglen är hissade,\r\nmot havets äventyr, en bild du målade.",
                AnswersId = 14
            },
            new Riddle{
                Id = 15, Question = "Första möbeln vi valde, med minnen så rika,\r\nen härlig plats för en härlig fika.",
                AnswersId = 15
            },
            new Riddle{
                Id = 16,
                Question = "Små och kraftfulla, gömda de är,\r\ni en låda dem sparas när ingen använder.",
                AnswersId = 16
            },
            new Riddle{
                Id = 17,
                Question = "Värmer i kylan, så mjuka de är,\r\nnär vinterkylan kommer, då fötterna de bär.",
                AnswersId = 17
            },
            new Riddle{
                Id = 18,
                Question = "I hyllans djup, där berättelser bor,\r\nhistorier och äventyr, i varje ord.",
                AnswersId = 18
            },
            new Riddle{
                Id = 19,
                Question = "I taktiskt spel, där tänkande är konst,\r\npå brädan dem kämpar, en duell av finaste sort.",
                AnswersId = 19
            },
            new Riddle{
                Id = 20,
                Question = "Med svarta och vita, en symfoni skapas,\r\ni tonernas värld, där musiken aldrig tappas.",
                AnswersId = 20
            },
            new Riddle{
                Id = 21,
                Question = "Den första gåvan, med blad breda och gröna,\r\nett tecken på kärlek, i vårt hem pryder en hörna.",
                AnswersId = 21
            },
            new Riddle{
                Id = 22,
                Question = "I lådan de glänser, för måltidens fest,\r\ni stål och i silver, de tjänar dig bäst.",
                AnswersId = 22
            },
            new Riddle{
                Id = 23,
                Question = "I skåpet de vilar, för hälsa och vård,\r\ni flaskor och burkar, trygghetens förråd.",
                AnswersId = 23
            },
            new Riddle{
                Id = 24,
                Question = "Varje gång han ser på dig, hans hjärta glöder,\r\nständigt kär, i varje ögonblick, kärleken flöder.",
                AnswersId = 24
            }

        };
    private readonly List<AnswersOptions> _answers = new()
        {
            new AnswersOptions(1, "Gitarr", "Under sängen", "Badrumsplantan"),
            new AnswersOptions(2, "Läsläxa", "Alias", "Kimble"),
            new AnswersOptions(3, "Skidan", "Släden", "Skridskon"),
            new AnswersOptions(4, "Violinen", "Harpan", "Gitarren"),
            new AnswersOptions(5, "Målning", "Fotografi", "Spegeln"),
            new AnswersOptions(6, "Stjärnhimlen", "Mona Lisa", "The Pope Never Dies"),
            new AnswersOptions(7, "Kryddburkarna", "Boksamlingen", "Vinflaskorna"),
            new AnswersOptions(8, "Soffan", "Fåtöljen", "Mattan i vardagsrummet"),
            new AnswersOptions(9, "Speglarna", "Bildramarna", "Klockan"),
            new AnswersOptions(10, "Slickepotten", "Stekpannan", "Grytvanten"),
            new AnswersOptions(11, "I skrivbordslådan", "Under sängen", "Bland ljusen"),
            new AnswersOptions(12, "Under byxorna", "Bland sockorna", "Djupt bland trosorna"),
            new AnswersOptions(13, "I bokhyllan", "På soffan", "Sindris skrivbord"),
            new AnswersOptions(14, "Bland muggarna", "Brödrosten", "Båt tavlorna"),
            new AnswersOptions(15, "Soffan", "Utemöblerna", "Vita stolen"),
            new AnswersOptions(16, "Under TV:n", "Verktygslådan", "Batterierna"),
            new AnswersOptions(17, "Vantarna", "Mössorna", "Yllesockorna"),
            new AnswersOptions(18, "Brevlådan", "Fotoalbumen", "Prippelns böcker"),
            new AnswersOptions(19, "Domino", "Kortspelet", "Schackbrädan"),
            new AnswersOptions(20, "Harpan", "Violen", "Piano"),
            new AnswersOptions(21, "Bambuplantan", "Kaktusen", "Elefantöra"),
            new AnswersOptions(22, "Kaffekopparna", "Servetterna", "Besticken"),
            new AnswersOptions(23, "Kryddor", "Olja", "Mediciner"),
            new AnswersOptions(24, "Tarzan", "Fabio", "Sindri")
        };
    private readonly List<Day> _days = new();

    public CalendarData()
    {
        SeedData();
    }

    public void SeedData()
    {
        for (int i = 1; i <= 24; i++)
        {
            var riddle = _riddles[i - 1];
            riddle.Answers = _answers[i - 1];
            var day = new Day { Id = i, Riddle = riddle };
            _days.Add(day);
        }
    }


    public IEnumerable<Day> GetDays() => _days;
}

