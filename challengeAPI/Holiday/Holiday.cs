namespace challengeAPI.Holiday
{
    public class Holiday
    {
        public DateTime InformedDate { get; set; }

        public static List<DateTime> GetHoliday(DateTime InformedDate)
        {
            var year = InformedDate.Year;

            var newYearDay = new DateTime(year, 1, 1);                //Ano novo
            var tiradentesDay = new DateTime(year, 4, 21);            //Tiradentes
            var labourDay = new DateTime(year, 5, 1);                 //Dia do Trabalhador
            var independenceDay = new DateTime(year, 9, 7);           //Dia da Independencia
            var nossaSenhoraDay = new DateTime(year, 10, 12);         //Dia de Nossa Senhora  
            var allSoulsDay = new DateTime(year, 11, 2);              //Dia de Finados
            var proclamationRepublicDay = new DateTime(year, 11, 15); //Proclamação da República
            var christmasDay = new DateTime(year, 12, 25);            //Natal                                                       
            var easterDay = EasterCalculator(InformedDate);           //Páscoa
            var carnivalDay = easterDay.AddDays(-47);                 //Carnaval
            var corpusChristDay = easterDay.AddDays(60);              //Cospus Christ
            var godsFridayDay = easterDay.AddDays(-2);                //Sexta Feira Santa

            var holidaysList = new List<DateTime>
            {
                newYearDay,
                carnivalDay,
                godsFridayDay,
                easterDay,
                tiradentesDay,
                labourDay,
                corpusChristDay,
                independenceDay,
                nossaSenhoraDay,
                allSoulsDay,
                proclamationRepublicDay,
                christmasDay
            };

            return holidaysList;
        }
        public static DateTime EasterCalculator(DateTime informedDate)
        {
            int year = informedDate.Year;
            int r1 = year % 19;
            int r2 = year % 4;
            int r3 = year % 7;
            int r4 = (19 * r1 + 24) % 30;
            int r5 = (6 * r4 + 4 * r3 + 2 * r2 + 5) % 7;
            DateTime easterDate = new DateTime(year, 3, 22).AddDays(r4 + r5);

            int day = easterDate.Day;
            if (day == 26)
            {
                easterDate = new DateTime(year, 4, 19);
            }
            else if (day == 25)
            {
                if (r1 > 10)
                    easterDate = new DateTime(year, 4, 18);
            }
            return easterDate.Date;
        }
        public static bool IsHoliday(DateTime informedDate)
        {
            var holidaylist = GetHoliday(informedDate);

            return holidaylist.Any(x => x.Date == informedDate);
        }
    }
}
    

