using Domain.Entities.Dtos;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Ricardo Martinez
    /// Class for add records to the tables 
    /// when the migration is running.
    /// </summary>
    public class V8Seeder
    {
        /// <summary>
        /// Ricardo Martinez.
        /// Method for fill the Divition Table
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void SeedDivition(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>().HasData(
                new Division { Id = 1, Name = "CUSTOMER CARE"},
                new Division { Id = 2, Name = "MARKETING" },
                new Division { Id = 3, Name = "OPERATION" },
                new Division { Id = 4, Name = "SALES" }
                );
        }

        /// <summary>
        /// Ricardo Martinez
        /// Method for create records when 
        /// the migration is running
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void SeedOffice(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Office>().HasData(
                new Office { Id = 1, Name = "A" },
                new Office { Id = 2, Name = "B" },
                new Office { Id = 3, Name = "C" },
                new Office { Id = 4, Name = "D" }
                );
        }

        /// <summary>
        /// Ricardo Martinez.
        /// Method for add positions when
        /// the migration is running
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void SeedPosition(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position { Id = 1, Name = "ACCOUNT EXECUTIVE" },
                new Position { Id = 2, Name = "CARGO ASSISTANT" },
                new Position { Id = 3, Name = "CARGO MANAGER" },
                new Position { Id = 4, Name = "CUSTOMER ASSISTANT" },
                new Position { Id = 5, Name = "CUSTOMER DIRECTOR" },
                new Position { Id = 6, Name = "HEAD OF CARGO" },
                new Position { Id = 7, Name = "MARKETING ASSISTANT" },
                new Position { Id = 8, Name = "SALES MANAGER" }
                );
        }

        /// <summary>
        /// Ricardo Martinez.
        /// MEthod for add 100 employees with theirs last
        /// 6 month salaries.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void SeedSalary(ModelBuilder modelBuilder)
        {
            //Variable to use
            List<Salary> salaries = new List<Salary>();
            int idSalary = 1;
            List<EmployeeDTO> employees = new List<EmployeeDTO>() 
            {
                new EmployeeDTO(){Code = "2032440" , Name = "LUIS" , SurName="JUAREZ" , BeginDate = new DateTime(2021,7,27), BirthDay = new DateTime(1992,10,10) , IdentificationNumber= "34877450", BaseSalary = 4061 },
                new EmployeeDTO(){Code = "2032439" , Name = "KATHERINE" , SurName="GARCIA" , BeginDate = new DateTime(2021,9,19), BirthDay = new DateTime(1984,6,25) , IdentificationNumber= "9041163", BaseSalary = 4935 },
                new EmployeeDTO(){Code = "2032438" , Name = "HAZEL" , SurName="OROZCO" , BeginDate = new DateTime(2021,3,15), BirthDay = new DateTime(1990,9,18) , IdentificationNumber= "35538733", BaseSalary = 2339 },
                new EmployeeDTO(){Code = "2032437" , Name = "BAYRON" , SurName="CHAVEZ" , BeginDate = new DateTime(2021,8,6), BirthDay = new DateTime(1995,8,20) , IdentificationNumber= "23711657", BaseSalary = 3128 },
                new EmployeeDTO(){Code = "2032436" , Name = "DAVID" , SurName="RODRIGUEZ" , BeginDate = new DateTime(2021,7,6), BirthDay = new DateTime(1975,3,25) , IdentificationNumber= "19133450", BaseSalary = 2304 },
                new EmployeeDTO(){Code = "2032435" , Name = "KARELIA" , SurName="VARGAS" , BeginDate = new DateTime(2021,9,9), BirthDay = new DateTime(1997,12,13) , IdentificationNumber= "34777526", BaseSalary = 2908 },
                new EmployeeDTO(){Code = "2032434" , Name = "NORWIN" , SurName="SOLANO" , BeginDate = new DateTime(2021,4,17), BirthDay = new DateTime(1984,12,30) , IdentificationNumber= "26637654", BaseSalary = 3200 },
                new EmployeeDTO(){Code = "2032433" , Name = "FRANCISCO" , SurName="ESPINOZA" , BeginDate = new DateTime(2021,8,29), BirthDay = new DateTime(1972,12,13) , IdentificationNumber= "38022829", BaseSalary = 3001 },
                new EmployeeDTO(){Code = "2032432" , Name = "MARLING" , SurName="CHAVEZ" , BeginDate = new DateTime(2021,6,7), BirthDay = new DateTime(1975,3,11) , IdentificationNumber= "31823310", BaseSalary = 3018 },
                new EmployeeDTO(){Code = "2032431" , Name = "TOURREN" , SurName="HOPPINGTON" , BeginDate = new DateTime(2021,3,1), BirthDay = new DateTime(1973,6,3) , IdentificationNumber= "41413887", BaseSalary = 2069 },
                new EmployeeDTO(){Code = "2032430" , Name = "DAYSI" , SurName="MONTES" , BeginDate = new DateTime(2021,6,28), BirthDay = new DateTime(1983,9,2) , IdentificationNumber= "33954617", BaseSalary = 3506 },
                new EmployeeDTO(){Code = "2032429" , Name = "MARJORY" , SurName="SOLORZANO" , BeginDate = new DateTime(2021,7,25), BirthDay = new DateTime(1989,6,30) , IdentificationNumber= "41462124", BaseSalary = 3374 },
                new EmployeeDTO(){Code = "2032428" , Name = "YENNY" , SurName="MARTINEZ" , BeginDate = new DateTime(2021,7,30), BirthDay = new DateTime(1983,4,29) , IdentificationNumber= "31111491", BaseSalary = 2568 },
                new EmployeeDTO(){Code = "2032427" , Name = "ORA" , SurName="JACKSON" , BeginDate = new DateTime(2021,10,12), BirthDay = new DateTime(1973,7,6) , IdentificationNumber= "17312991", BaseSalary = 4371 },
                new EmployeeDTO(){Code = "2032426" , Name = "ALBIN" , SurName="HAMILTON" , BeginDate = new DateTime(2021,9,5), BirthDay = new DateTime(1987,12,23) , IdentificationNumber= "31602242", BaseSalary = 4226 },
                new EmployeeDTO(){Code = "2032425" , Name = "HAYDEE" , SurName="ARGENAL" , BeginDate = new DateTime(2021,4,22), BirthDay = new DateTime(1989,5,28) , IdentificationNumber= "8208741", BaseSalary = 2911 },
                new EmployeeDTO(){Code = "2032424" , Name = "ALEXA" , SurName="GUTIERREZ" , BeginDate = new DateTime(2021,10,8), BirthDay = new DateTime(1977,7,22) , IdentificationNumber= "4556179", BaseSalary = 4596 },
                new EmployeeDTO(){Code = "2032423" , Name = "PAMELA" , SurName="LOPEZ" , BeginDate = new DateTime(2021,7,5), BirthDay = new DateTime(1983,9,26) , IdentificationNumber= "8386388", BaseSalary = 2668 },
                new EmployeeDTO(){Code = "2032422" , Name = "OSMAR" , SurName="MORALES" , BeginDate = new DateTime(2021,9,13), BirthDay = new DateTime(1996,1,21) , IdentificationNumber= "24791557", BaseSalary = 2844 },
                new EmployeeDTO(){Code = "2032421" , Name = "VICTOR" , SurName="SANCHEZ" , BeginDate = new DateTime(2021,1,8), BirthDay = new DateTime(1984,1,12) , IdentificationNumber= "11512637", BaseSalary = 2156 },
                new EmployeeDTO(){Code = "2032420" , Name = "OSCAR" , SurName="MARTIN" , BeginDate = new DateTime(2021,6,9), BirthDay = new DateTime(1997,5,20) , IdentificationNumber= "16206830", BaseSalary = 4481 },
                new EmployeeDTO(){Code = "2032419" , Name = "CRISTHIAM" , SurName="SANCHEZ" , BeginDate = new DateTime(2021,7,12), BirthDay = new DateTime(1984,8,10) , IdentificationNumber= "6470372", BaseSalary = 2373 },
                new EmployeeDTO(){Code = "2032418" , Name = "JUAN" , SurName="ALVARADO" , BeginDate = new DateTime(2021,2,27), BirthDay = new DateTime(1972,1,11) , IdentificationNumber= "24547021", BaseSalary = 4323 },
                new EmployeeDTO(){Code = "2032417" , Name = "RONALDO" , SurName="GONZALEZ" , BeginDate = new DateTime(2021,2,9), BirthDay = new DateTime(1993,10,20) , IdentificationNumber= "19979160", BaseSalary = 2194 },
                new EmployeeDTO(){Code = "2032416" , Name = "HEYLING" , SurName="SOZA" , BeginDate = new DateTime(2021,2,28), BirthDay = new DateTime(1990,7,13) , IdentificationNumber= "4103692", BaseSalary = 2784 },
                new EmployeeDTO(){Code = "2032415" , Name = "ARIEL" , SurName="BURGOS" , BeginDate = new DateTime(2021,4,21), BirthDay = new DateTime(1980,8,24) , IdentificationNumber= "40907956", BaseSalary = 2072 },
                new EmployeeDTO(){Code = "2032414" , Name = "ERICK" , SurName="VALLECILLO" , BeginDate = new DateTime(2021,8,28), BirthDay = new DateTime(1997,10,20) , IdentificationNumber= "24314887", BaseSalary = 4439 },
                new EmployeeDTO(){Code = "2032413" , Name = "HADSON" , SurName="JARQUIN" , BeginDate = new DateTime(2021,1,20), BirthDay = new DateTime(1975,4,19) , IdentificationNumber= "25001678", BaseSalary = 3445 },
                new EmployeeDTO(){Code = "2032412" , Name = "LEONARDO" , SurName="JUAREZ" , BeginDate = new DateTime(2021,7,8), BirthDay = new DateTime(1984,3,20) , IdentificationNumber= "12055409", BaseSalary = 2933 },
                new EmployeeDTO(){Code = "2032411" , Name = "SAULO" , SurName="GOMEZ" , BeginDate = new DateTime(2021,9,30), BirthDay = new DateTime(1986,9,14) , IdentificationNumber= "26257282", BaseSalary = 3110 },
                new EmployeeDTO(){Code = "2032410" , Name = "SERGIO" , SurName="REYES" , BeginDate = new DateTime(2021,1,24), BirthDay = new DateTime(1975,3,23) , IdentificationNumber= "39191653", BaseSalary = 4821 },
                new EmployeeDTO(){Code = "2032409" , Name = "EYRA" , SurName="MEDRANO" , BeginDate = new DateTime(2021,5,11), BirthDay = new DateTime(1993,1,27) , IdentificationNumber= "45353442", BaseSalary = 2161 },
                new EmployeeDTO(){Code = "2032408" , Name = "KEVIN" , SurName="MAYORGA" , BeginDate = new DateTime(2021,4,1), BirthDay = new DateTime(1986,6,20) , IdentificationNumber= "28912452", BaseSalary = 2499 },
                new EmployeeDTO(){Code = "2032407" , Name = "ROXANA" , SurName="CUADRA" , BeginDate = new DateTime(2021,5,30), BirthDay = new DateTime(1986,5,15) , IdentificationNumber= "35043455", BaseSalary = 4296 },
                new EmployeeDTO(){Code = "2032406" , Name = "DANILO" , SurName="CABEZAS" , BeginDate = new DateTime(2021,9,7), BirthDay = new DateTime(1988,9,25) , IdentificationNumber= "40710417", BaseSalary = 4470 },
                new EmployeeDTO(){Code = "2032405" , Name = "TANIA" , SurName="SANCHEZ" , BeginDate = new DateTime(2021,9,10), BirthDay = new DateTime(1988,6,18) , IdentificationNumber= "5677095", BaseSalary = 4443 },
                new EmployeeDTO(){Code = "2032404" , Name = "KELLY" , SurName="CASTANEDA" , BeginDate = new DateTime(2021,5,3), BirthDay = new DateTime(1991,9,15) , IdentificationNumber= "27519652", BaseSalary = 3398 },
                new EmployeeDTO(){Code = "2032403" , Name = "ENMANUEL" , SurName="PALACIOS" , BeginDate = new DateTime(2021,3,29), BirthDay = new DateTime(1988,3,6) , IdentificationNumber= "15649980", BaseSalary = 4815 },
                new EmployeeDTO(){Code = "2032402" , Name = "KARLA" , SurName="BLANDINO" , BeginDate = new DateTime(2021,1,20), BirthDay = new DateTime(1972,3,29) , IdentificationNumber= "35162403", BaseSalary = 2858 },
                new EmployeeDTO(){Code = "2032401" , Name = "PAULA" , SurName="ORDONEZ" , BeginDate = new DateTime(2021,7,27), BirthDay = new DateTime(1987,8,15) , IdentificationNumber= "44111797", BaseSalary = 4938 },
                new EmployeeDTO(){Code = "2032400" , Name = "HILLARY" , SurName="ANDINO" , BeginDate = new DateTime(2021,2,4), BirthDay = new DateTime(1996,11,14) , IdentificationNumber= "14516770", BaseSalary = 3571 },
                new EmployeeDTO(){Code = "2032399" , Name = "BLANCA" , SurName="MORALES" , BeginDate = new DateTime(2021,2,1), BirthDay = new DateTime(1985,11,1) , IdentificationNumber= "29003040", BaseSalary = 2315 },
                new EmployeeDTO(){Code = "2032398" , Name = "LESLY" , SurName="FERNANDEZ" , BeginDate = new DateTime(2021,5,2), BirthDay = new DateTime(1977,4,4) , IdentificationNumber= "21713943", BaseSalary = 3676 },
                new EmployeeDTO(){Code = "2032397" , Name = "JULIA" , SurName="GARCIA" , BeginDate = new DateTime(2021,4,16), BirthDay = new DateTime(1984,10,27) , IdentificationNumber= "32459349", BaseSalary = 3461 },
                new EmployeeDTO(){Code = "2032396" , Name = "REYNALDO" , SurName="MEJIA" , BeginDate = new DateTime(2021,1,8), BirthDay = new DateTime(1989,6,12) , IdentificationNumber= "39179324", BaseSalary = 3276 },
                new EmployeeDTO(){Code = "2032395" , Name = "ERICK" , SurName="GARCIA" , BeginDate = new DateTime(2021,1,27), BirthDay = new DateTime(1986,2,15) , IdentificationNumber= "16786337", BaseSalary = 4147 },
                new EmployeeDTO(){Code = "2032394" , Name = "ELEYDA" , SurName="BLANDON" , BeginDate = new DateTime(2021,7,12), BirthDay = new DateTime(1975,4,11) , IdentificationNumber= "23466744", BaseSalary = 4203 },
                new EmployeeDTO(){Code = "2032393" , Name = "HENRY" , SurName="ROBLETO" , BeginDate = new DateTime(2021,4,5), BirthDay = new DateTime(1978,12,19) , IdentificationNumber= "39969291", BaseSalary = 2956 },
                new EmployeeDTO(){Code = "2032392" , Name = "WILTON" , SurName="HUMPHREYS" , BeginDate = new DateTime(2021,4,4), BirthDay = new DateTime(1987,6,24) , IdentificationNumber= "3467396", BaseSalary = 3620 },
                new EmployeeDTO(){Code = "2032391" , Name = "FRANCISCO" , SurName="RUIZ" , BeginDate = new DateTime(2021,5,12), BirthDay = new DateTime(1980,4,10) , IdentificationNumber= "42818064", BaseSalary = 3255 },
                new EmployeeDTO(){Code = "2032390" , Name = "NORMA" , SurName="TAISIGUE" , BeginDate = new DateTime(2021,9,2), BirthDay = new DateTime(1991,5,15) , IdentificationNumber= "42582994", BaseSalary = 2174 },
                new EmployeeDTO(){Code = "2032389" , Name = "ENRIQUE" , SurName="HERNANDEZ" , BeginDate = new DateTime(2021,3,26), BirthDay = new DateTime(1982,8,2) , IdentificationNumber= "26937085", BaseSalary = 2923 },
                new EmployeeDTO(){Code = "2032388" , Name = "EDDY" , SurName="MELENDEZ" , BeginDate = new DateTime(2021,1,9), BirthDay = new DateTime(1983,7,6) , IdentificationNumber= "21674906", BaseSalary = 3920 },
                new EmployeeDTO(){Code = "2032387" , Name = "BRYAN" , SurName="BERMUDEZ" , BeginDate = new DateTime(2021,5,28), BirthDay = new DateTime(1980,11,17) , IdentificationNumber= "3125873", BaseSalary = 4430 },
                new EmployeeDTO(){Code = "2032386" , Name = "ALVIN" , SurName="ARAICA" , BeginDate = new DateTime(2021,3,29), BirthDay = new DateTime(1995,3,17) , IdentificationNumber= "5434979", BaseSalary = 3976 },
                new EmployeeDTO(){Code = "2032385" , Name = "AYLENE" , SurName="RODRIGUEZ" , BeginDate = new DateTime(2021,7,3), BirthDay = new DateTime(1973,10,5) , IdentificationNumber= "45206736", BaseSalary = 3287 },
                new EmployeeDTO(){Code = "2032384" , Name = "CARLOS" , SurName="ACUNA" , BeginDate = new DateTime(2021,2,13), BirthDay = new DateTime(1977,10,10) , IdentificationNumber= "11081906", BaseSalary = 2414 },
                new EmployeeDTO(){Code = "2032383" , Name = "JUAN" , SurName="ALVAREZ" , BeginDate = new DateTime(2021,4,23), BirthDay = new DateTime(1978,6,16) , IdentificationNumber= "17193118", BaseSalary = 2268 },
                new EmployeeDTO(){Code = "2032382" , Name = "VIRGINIA" , SurName="GUIDO" , BeginDate = new DateTime(2021,8,24), BirthDay = new DateTime(1987,1,12) , IdentificationNumber= "28542877", BaseSalary = 2740 },
                new EmployeeDTO(){Code = "2032381" , Name = "LEONEL" , SurName="MELENDEZ" , BeginDate = new DateTime(2021,2,5), BirthDay = new DateTime(1973,6,20) , IdentificationNumber= "8177551", BaseSalary = 4978 },
                new EmployeeDTO(){Code = "2032380" , Name = "YORDI" , SurName="BARRAZA" , BeginDate = new DateTime(2021,5,28), BirthDay = new DateTime(1981,3,22) , IdentificationNumber= "45175094", BaseSalary = 4252 },
                new EmployeeDTO(){Code = "2032379" , Name = "ANABEL" , SurName="GARCIA" , BeginDate = new DateTime(2021,9,8), BirthDay = new DateTime(1978,12,26) , IdentificationNumber= "16906687", BaseSalary = 3549 },
                new EmployeeDTO(){Code = "2032378" , Name = "JOSE" , SurName="ESTRADA" , BeginDate = new DateTime(2021,1,2), BirthDay = new DateTime(1996,9,3) , IdentificationNumber= "24582177", BaseSalary = 2873 },
                new EmployeeDTO(){Code = "2032377" , Name = "DAVID" , SurName="MORALES" , BeginDate = new DateTime(2021,9,28), BirthDay = new DateTime(1971,4,13) , IdentificationNumber= "23948768", BaseSalary = 4601 },
                new EmployeeDTO(){Code = "2032376" , Name = "YELDING" , SurName="MEDINA" , BeginDate = new DateTime(2021,10,1), BirthDay = new DateTime(1983,2,6) , IdentificationNumber= "8506454", BaseSalary = 2575 },
                new EmployeeDTO(){Code = "2032375" , Name = "LILIA" , SurName="VANEGAS" , BeginDate = new DateTime(2021,9,4), BirthDay = new DateTime(1994,1,28) , IdentificationNumber= "44387218", BaseSalary = 3900 },
                new EmployeeDTO(){Code = "2032374" , Name = "ROBERTO" , SurName="DAVILA" , BeginDate = new DateTime(2021,7,14), BirthDay = new DateTime(1985,11,23) , IdentificationNumber= "28080896", BaseSalary = 2141 },
                new EmployeeDTO(){Code = "2032373" , Name = "SATURNINO" , SurName="MONTENEGRO" , BeginDate = new DateTime(2021,9,25), BirthDay = new DateTime(1984,5,26) , IdentificationNumber= "9388196", BaseSalary = 3265 },
                new EmployeeDTO(){Code = "2032372" , Name = "TARSIS" , SurName="ACUÑA" , BeginDate = new DateTime(2021,6,8), BirthDay = new DateTime(1984,10,29) , IdentificationNumber= "37554912", BaseSalary = 2184 },
                new EmployeeDTO(){Code = "2032371" , Name = "GRACIELA" , SurName="CABALLERO" , BeginDate = new DateTime(2021,7,28), BirthDay = new DateTime(1975,12,11) , IdentificationNumber= "44227272", BaseSalary = 4914 },
                new EmployeeDTO(){Code = "2032370" , Name = "EMPERATRIZ" , SurName="BLANDINO" , BeginDate = new DateTime(2021,8,10), BirthDay = new DateTime(1980,12,25) , IdentificationNumber= "5419134", BaseSalary = 2541 },
                new EmployeeDTO(){Code = "2032369" , Name = "ENEYDA" , SurName="ESPINO" , BeginDate = new DateTime(2021,1,15), BirthDay = new DateTime(1985,5,6) , IdentificationNumber= "39714685", BaseSalary = 4267 },
                new EmployeeDTO(){Code = "2032368" , Name = "LUIS" , SurName="LOVO" , BeginDate = new DateTime(2021,4,17), BirthDay = new DateTime(1996,10,3) , IdentificationNumber= "19323280", BaseSalary = 2880 },
                new EmployeeDTO(){Code = "2032367" , Name = "CARMEN" , SurName="MORALES" , BeginDate = new DateTime(2021,2,16), BirthDay = new DateTime(1983,4,29) , IdentificationNumber= "11138508", BaseSalary = 3023 },
                new EmployeeDTO(){Code = "2032366" , Name = "MOISES" , SurName="LAZO" , BeginDate = new DateTime(2021,2,21), BirthDay = new DateTime(1972,1,18) , IdentificationNumber= "33568965", BaseSalary = 2907 },
                new EmployeeDTO(){Code = "2032365" , Name = "NOE" , SurName="BORGE" , BeginDate = new DateTime(2021,5,7), BirthDay = new DateTime(1972,10,2) , IdentificationNumber= "30630023", BaseSalary = 2932 },
                new EmployeeDTO(){Code = "2032364" , Name = "JAY" , SurName="TORRENTES" , BeginDate = new DateTime(2021,8,19), BirthDay = new DateTime(1971,5,7) , IdentificationNumber= "21675930", BaseSalary = 4683 },
                new EmployeeDTO(){Code = "2032363" , Name = "NORIEL" , SurName="SALGUERA" , BeginDate = new DateTime(2021,1,6), BirthDay = new DateTime(1994,12,2) , IdentificationNumber= "20789713", BaseSalary = 3446 },
                new EmployeeDTO(){Code = "2032362" , Name = "DIANA" , SurName="FIGUEROA" , BeginDate = new DateTime(2021,2,9), BirthDay = new DateTime(1982,9,19) , IdentificationNumber= "8657208", BaseSalary = 3132 },
                new EmployeeDTO(){Code = "2032361" , Name = "LUISAMARA" , SurName="MORENO" , BeginDate = new DateTime(2021,3,29), BirthDay = new DateTime(1977,10,14) , IdentificationNumber= "27450930", BaseSalary = 2711 },
                new EmployeeDTO(){Code = "2032360" , Name = "ANTHONY" , SurName="HODGSON" , BeginDate = new DateTime(2021,8,14), BirthDay = new DateTime(1977,7,25) , IdentificationNumber= "16413472", BaseSalary = 3706 },
                new EmployeeDTO(){Code = "2032359" , Name = "PERLA" , SurName="CABRERA" , BeginDate = new DateTime(2021,5,16), BirthDay = new DateTime(1972,8,20) , IdentificationNumber= "40578545", BaseSalary = 2927 },
                new EmployeeDTO(){Code = "2032358" , Name = "JAVIER" , SurName="ZAMORA" , BeginDate = new DateTime(2021,1,18), BirthDay = new DateTime(1993,4,19) , IdentificationNumber= "11428614", BaseSalary = 4172 },
                new EmployeeDTO(){Code = "2032357" , Name = "ELIZABETH" , SurName="JUÁREZ" , BeginDate = new DateTime(2021,6,10), BirthDay = new DateTime(1972,4,26) , IdentificationNumber= "6918240", BaseSalary = 4133 },
                new EmployeeDTO(){Code = "2032356" , Name = "EYDER" , SurName="ALVAREZ" , BeginDate = new DateTime(2021,10,3), BirthDay = new DateTime(1972,5,16) , IdentificationNumber= "28586950", BaseSalary = 4010 },
                new EmployeeDTO(){Code = "2032355" , Name = "GIOCONDA" , SurName="ESPINO" , BeginDate = new DateTime(2021,7,28), BirthDay = new DateTime(1985,1,26) , IdentificationNumber= "42872115", BaseSalary = 2785 },
                new EmployeeDTO(){Code = "2032354" , Name = "MERY" , SurName="PÉREZ" , BeginDate = new DateTime(2021,2,25), BirthDay = new DateTime(1980,5,16) , IdentificationNumber= "44749289", BaseSalary = 2435 },
                new EmployeeDTO(){Code = "2032353" , Name = "WALTER" , SurName="MENDOZA" , BeginDate = new DateTime(2021,9,2), BirthDay = new DateTime(1994,11,20) , IdentificationNumber= "25532938", BaseSalary = 2928 },
                new EmployeeDTO(){Code = "2032352" , Name = "JENNY" , SurName="GUZMAN" , BeginDate = new DateTime(2021,3,24), BirthDay = new DateTime(1993,12,29) , IdentificationNumber= "25134015", BaseSalary = 4463 },
                new EmployeeDTO(){Code = "2032351" , Name = "DEYRIN" , SurName="VINDELL" , BeginDate = new DateTime(2021,3,17), BirthDay = new DateTime(1972,5,14) , IdentificationNumber= "16515860", BaseSalary = 4748 },
                new EmployeeDTO(){Code = "2032350" , Name = "JORGE" , SurName="ROMAN" , BeginDate = new DateTime(2021,1,3), BirthDay = new DateTime(1997,3,27) , IdentificationNumber= "3440497", BaseSalary = 2934 },
                new EmployeeDTO(){Code = "2032349" , Name = "JUAN" , SurName="PELAEZ" , BeginDate = new DateTime(2021,8,15), BirthDay = new DateTime(1983,11,8) , IdentificationNumber= "39967136", BaseSalary = 2500 },
                new EmployeeDTO(){Code = "2032348" , Name = "ALLAN" , SurName="CALERO" , BeginDate = new DateTime(2021,7,13), BirthDay = new DateTime(1978,4,14) , IdentificationNumber= "20220297", BaseSalary = 2398 },
                new EmployeeDTO(){Code = "2032347" , Name = "FRANCISCO" , SurName="BALDELOMAR" , BeginDate = new DateTime(2021,6,25), BirthDay = new DateTime(1989,8,9) , IdentificationNumber= "32283414", BaseSalary = 4888 },
                new EmployeeDTO(){Code = "2032346" , Name = "WILLIAM" , SurName="GAMBOA" , BeginDate = new DateTime(2021,3,6), BirthDay = new DateTime(1984,3,16) , IdentificationNumber= "18632460", BaseSalary = 3280 },
                new EmployeeDTO(){Code = "2032345" , Name = "LIZANGELA" , SurName="RODRIGUEZ" , BeginDate = new DateTime(2021,1,23), BirthDay = new DateTime(1975,8,13) , IdentificationNumber= "5980831", BaseSalary = 3613 },
                new EmployeeDTO(){Code = "2032344" , Name = "JONATHAN" , SurName="CORONADO" , BeginDate = new DateTime(2021,6,16), BirthDay = new DateTime(1987,5,15) , IdentificationNumber= "20152491", BaseSalary = 2311 },
                new EmployeeDTO(){Code = "2032343" , Name = "PEDRO" , SurName="ESPINOZA" , BeginDate = new DateTime(2021,8,5), BirthDay = new DateTime(1990,8,2) , IdentificationNumber= "18906271", BaseSalary = 3991 },
                new EmployeeDTO(){Code = "2032342" , Name = "MARIANO" , SurName="SANCHEZ" , BeginDate = new DateTime(2021,1,30), BirthDay = new DateTime(1986,5,18) , IdentificationNumber= "39003125", BaseSalary = 3990 },
                new EmployeeDTO(){Code = "2032341" , Name = "CELESTINO" , SurName="BUCARDO" , BeginDate = new DateTime(2021,3,13), BirthDay = new DateTime(1996,10,3) , IdentificationNumber= "13039132", BaseSalary = 3894 },

            };

            Random ra = new Random();

            //Adding last 6 month salary for each employee
            foreach (EmployeeDTO dto in employees)  
            {
                for (int i = 1; i <= 6; i++)
                {
                    Salary salary = new Salary();
                    salary.Id = idSalary;
                    salary.Year = 2021;
                    salary.Month = ra.Next(1, 12);
                    salary.EmployeeCode = dto.Code;
                    salary.EmployeeName = dto.Name;
                    salary.EmployeeSurname = dto.SurName;
                    salary.Grade = ra.Next(6, 18);
                    salary.BeginDate = dto.BeginDate;
                    salary.Birthday = dto.BirthDay;
                    salary.IdentificationNumber = dto.IdentificationNumber;
                    salary.BaseSalary = dto.BaseSalary;
                    salary.ProductionBonus = (salary.BaseSalary >= 3000 ? 0 : ra.Next((int)salary.BaseSalary - 500, (int)salary.BaseSalary + 300));
                    salary.CompensationBonus = ra.Next(900, 3300);
                    salary.Commission = ra.Next(800, 5000);
                    salary.Contributions = ra.Next(600,2300);
                    salary.DivisionID = ra.Next(1, 4);
                    salary.OfficeID = ra.Next(1,4);
                    salary.PositionID = ra.Next(1, 8);

                    //we have to validate the month salary must be unique in that year
                    while (salaries.Exists(x => x.EmployeeCode == salary.EmployeeCode && x.Month == salary.Month))
                    {
                        salary.Month = ra.Next(1, 12);
                    }


                    salaries.Add(salary);

                    //new IdSalary
                    idSalary++;
                }
            }

            //Inserting into to the databases
            modelBuilder.Entity<Salary>().HasData(salaries);
        }
    }
}
