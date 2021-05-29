using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace risk_menegment
{
    class RiskManager
    {
        //Dictionary<string, double> d = new Dictionary<string, double>;


        //public static readonly KeyValuePair<string, string[]>[] RiskSources = new KeyValuePair<string, string[]>[]


        //List<double[]> values = new List<double[]>();

        //values.AddRange(new List<double[]>{
        //new double[7] { 0.29, 0.49, 0.38, 0.49, 0.66, 0.46, 0.05 },
        //new double[3] { 0.33, 0.79, 0.07 },
        //new double[3] { 0.43, 0.85, 0.21 },
        //new double[5] { 0.26, 0.72, 0.39, 0.44, 0.95 }
        //});

        //public static readonly KeyValuePair<string, KeyValuePair<string, double>[]>[] RiskSources = new KeyValuePair<string, KeyValuePair<string, double>[]>[]
        //{

        //    new KeyValuePair<string, KeyValuePair<string, double>[]>(
        //    "Множина джерел появи технічних ризиків",
        //    new KeyValuePair<string, double>[]
        //    {
        //        new KeyValuePair<string, double>( "Функціональні характеристики ПЗ", 0.29 ),
        //        new KeyValuePair<string, double>( "Характеристики якості ПЗ", 0.49 ),
        //        new KeyValuePair<string, double>( "Характеристики надійності ПЗ", 0.38 ),
        //        new KeyValuePair<string, double>( "Застосовність ПЗ", 0.49 ),
        //        new KeyValuePair<string, double>( "Часова продуктивність ПЗ", 0.66 ),
        //        new KeyValuePair<string, double>( "Супроводжуваність ПЗ", 0.46 ),
        //        new KeyValuePair<string, double>( "Повторне використання компонент ПЗ", 0.05 )
        //    }
        //    ),
        //    new KeyValuePair<string, KeyValuePair<string, double>[]>(
        //        "Множина джерел появи вартісних ризиків",
        //        new KeyValuePair<string, double>[]
        //        {
        //            new KeyValuePair<string, double>("Обмеження сумарного бюджету на програмний проект", 0.33 ),
        //            new KeyValuePair<string, double>("Недоступна вартість реалізації програмного проекту", 0.79 ),
        //            new KeyValuePair<string, double>("Низька ступінь реалізму при оцінюванні витрат на програмний проект", 0.07 )
        //        }
        //    ),
        //    new KeyValuePair<string, KeyValuePair<string, double>[]>(
        //        "Множина джерел появи планових ризиків",
        //        new KeyValuePair<string, double>[]
        //        {
        //            new KeyValuePair<string, double>("Властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ", 0.43),
        //            new KeyValuePair<string, double>("Можливості порушення встановлених термінів реалізації етапів життєвого циклу розроблення ПЗ", 0.85),
        //            new KeyValuePair<string, double>("Низька ступінь реалізму при встановленні планів і етапів життєвого циклу розроблення ПЗ", 0.21)
        //        }
        //    ),
        //    new KeyValuePair<string, KeyValuePair<string, double>[]>(
        //        "Множина джерел появи ризиків реалізації процесу управління програмним проектом",
        //        new KeyValuePair<string, double>[]
        //        {
        //             new KeyValuePair<string, double>( "Хибна стратегія реалізації програмного проекту", 0.26 ),
        //             new KeyValuePair<string, double>("Неефективне планування проекту розроблення ПЗ", 0.72 ),
        //             new KeyValuePair<string, double>("Неякісне оцінювання програмного проекту", 0.39 ),
        //             new KeyValuePair<string, double>("Прогалини в документуванні етапів реалізації програмного проекту", 0.44 ),
        //             new KeyValuePair<string, double>("Промахи в прогнозуванні результатів реалізації програмного проекту", 0.95 )
        //        }
        //    )
        //    };


        public static readonly KeyValuePair<string, string[]>[] RiskSources = new KeyValuePair<string, string[]>[]
               {
            new KeyValuePair<string, string[]>(
                "Множина джерел появи технічних ризиків",
                new string[]
                {
                     "Функціональні характеристики ПЗ",
                     "Характеристики якості ПЗ",
                     "Характеристики надійності ПЗ",
                     "Застосовність ПЗ",
                     "Часова продуктивність ПЗ",
                     "Супроводжуваність ПЗ",
                     "Повторне використання компонент ПЗ"
                }),
            new KeyValuePair<string, string[]>(
                "Множина джерел появи вартісних ризиків",
                new string[]
                {
                    "Обмеження сумарного бюджету на програмний проект",
                    "Недоступна вартість реалізації програмного проекту",
                    "Низька ступінь реалізму при оцінюванні витрат на програмний проект"
                }
            ),
            new KeyValuePair<string, string[]>(
                "Множина джерел появи планових ризиків",
                new string[]
                {
                    "Властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ",
                    "Можливості порушення встановлених термінів реалізації етапів життєвого циклу розроблення ПЗ",
                    "Низька ступінь реалізму при встановленні планів і етапів життєвого циклу розроблення ПЗ"
                }
            ),
            new KeyValuePair<string, string[]>(
                "Множина джерел появи ризиків реалізації процесу управління програмним проектом",
                new string[]
                {
                     "Хибна стратегія реалізації програмного проекту",
                     "Неефективне планування проекту розроблення ПЗ",
                     "Неякісне оцінювання програмного проекту",
                     "Прогалини в документуванні етапів реалізації програмного проекту",
                     "Промахи в прогнозуванні результатів реалізації програмного проекту"
                }
            )
               };
        public static readonly KeyValuePair<string, string[]>[] RiskEvents = new KeyValuePair<string, string[]>[]
            {
            new KeyValuePair<string, string[]>(
                "Множина настання технічних ризикових подій",
                new string[]
                {
                     "Затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ",
                     "Затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ",
                     "Небажання команди виконавців використовувати інструментальні засоби для підтримки процесу розроблення ПЗ",
                     "Формування запитів на більш потужні інструментальні засоби розроблення ПЗ",
                     "Відмова команди виконавців від CASE-засобів розроблення ПЗ",
                     "Неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ",
                     "Неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ",
                     "Недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ",
                     "Програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості",
                     "Швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів",
                     "Поява дефектних системних компонент, які використовують для розроблення ПЗ"
                }
            ),
            new KeyValuePair<string, string[]>(
                "Множина настання вартісних ризикових подій",
                new string[]
                {
                    "Недо(пере)оцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)",
                    "Фінансові ускладнення у компанії-замовника ПЗ",
                    "Фінансові ускладнення у компанії-розробника ПЗ",
                    "Змен(збіль)шення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації",
                    "Висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ",
                    "Реорганізація структурних підрозділів у компанії-замовника ПЗ",
                    "Реорганізація команди виконавців у компанії-розробника ПЗ"
                }
            ),
            new KeyValuePair<string, string[]>(
                "Множина настання планових ризикових подій",
                new string[]
                {
                    "Зміни графіка виконання робіт з боку замовника чи розробника ПЗ",
                    "Порушення графіка виконання робіт з боку компанії-розробника ПЗ",
                    "Потреба зміни користувацьких вимог до ПЗ з боку компанії-замовника ПЗ",
                    "Потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ",
                    "Потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ",
                    "Недо(пере)оцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ",
                    "Остаточний розмір ПЗ значно перевищує(менший від) заплановані(их) його характеристики",
                    "Поява на ринку аналогічного ПЗ до виходу замовленого",
                    "Поява на ринку більш конкурентоздатного ПЗ"
                }
            ),
            new KeyValuePair<string, string[]>(
                "Множина настання ризикових подій реалізації процесу управління програмним проектом",
                new string[]
                {
                    "Низький моральний стан персоналу команди виконавців ПЗ",
                    "Низька взаємодія між членами команди виконавців ПЗ",
                    "Пасивність керівника(менеджера) програмного проекту",
                    "Недостатня компетентність керівника(менеджера) програмного проекту",
                    "Незадоволеність замовника результатами етапів реалізації програмного проекту",
                    "Недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем",
                    "Хвороба провідного виконавця в найкритичніший момент розроблення ПЗ",
                    "Одночасна хвороба декількох виконавців підчас розроблення ПЗ",
                    "Неможливість організації необхідного навчання персоналу команди виконавців ПЗ",
                    "Зміна пріоритетів у процесі управління програмним проектом",
                    "Недо(пере)оцінювання необхідної кількості розробників(підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ",
                    "Недостатнє(надмірне) документування результатів на етапах реалізації програмного проекту",
                    "Нереалістичне прогнозування результатів на етапах реалізації програмного проекту",
                    "Недостатній професійний рівень представників від компанії-замовника ПЗ"
                }
            )
            };
            public static readonly int RiskTypesCount = 4;
            public static readonly string[] RiskTypes = { "t", "c", "p", "m" };
            public static readonly int RiskSourcesTotalCount = 18;
            public static readonly int RiskEventsTotalCount = 41;

            static RiskManager()
            {
                PreventionMethodsEffectiveness = new double[PreventionMethodsCount];
                Random rand = new Random();
                for (int i = 0; i < PreventionMethodsCount; ++i)
                {
                    PreventionMethodsEffectiveness[i] = rand.NextDouble();
                }
            }

            public List<KeyValuePair<int, double>[]> RiskSourcesValues;
            public List<KeyValuePair<int, double>[]> RiskEventsValues;
            
            public readonly int[][] altRiskSourcesValues;
            public readonly int[][] altRiskEventsValues;

            public readonly KeyValuePair<string, double>[] RiskSourcesProbabilities = new KeyValuePair<string, double>[RiskTypesCount];
            public readonly KeyValuePair<string, double>[] RiskEventsProbabilities = new KeyValuePair<string, double>[RiskTypesCount];
            public readonly KeyValuePair<string, double>[] altRiskSourcesProbabilities = new KeyValuePair<string, double>[RiskTypesCount];
            public readonly KeyValuePair<string, double>[] altRiskEventsProbabilities = new KeyValuePair<string, double>[RiskTypesCount];

        public static readonly int ExpertsCount = 10;
            public readonly double[][][] ExpertsGrades;
            public readonly double[][] ER;
            public readonly double[][] LRER;
            public readonly double[][] VRER;

            private readonly int[] ExpertsWage = new int[ExpertsCount];
            public readonly double[][][] WagedExpertsGrade;

            public static readonly string[] PreventionMethods =
            {
            "Попереднє навчання членів проектного колективу",
            "Узгодження детального переліку вимог до ПЗ із замовником",
            "Внесення узгодженого переліку вимог до ПЗ замовника в договір",
            "Точне слідування вимогам замовника з узгодженого переліку вимог до ПЗ",
            "Попередні дослідження ринку",
            "Експертна оцінка програмного проекту досвідченим стороннім консультантом",
            "Консультації досвідченого стороннього консультанта",
            "Тренінг з вивчення необхідних інструментів розроблення ПЗ",
            "Укладання договору страхування",
            "Використання \"шаблонних\" рішень з вдалих попередніх проектів при управлінні програмним проектом",
            "Підготовка документів, які показують важливість даного проекту для досягнення фінансових цілей компанії-розробника",
            "Реорганізація роботи проектного колективу так, щоб обов'язки та робота членів колективу перекривали один одного",
            "Придбання(замовлення) частини компонент розроблюваного ПЗ",
            "Заміна потенційно дефектних компонент розроблюваного ПЗ придбаними компонентами, які гарантують якість виконання роботи",
            "Придбання більш продуктивної бази даних",
            "Використання генератора програмного коду",
            "Реорганізація роботи проектного колективу залежно від рівня труднощів виконання завдань та професійних рівнів розробників",
            "Повторне використання придатних компонент ПЗ, які були розроблені для інших програмних проектів",
            "Аналіз доцільності розроблення даного ПЗ"
        };
            public static readonly int PreventionMethodsCount = 19;
            private static readonly double[] PreventionMethodsEffectiveness;

            public readonly int[][] SelectedPreventions;
            public readonly double[][][] EVER;
            public readonly double[][] ERPER;
            public readonly double[][] ELRER;
            public readonly double[][] EVRER;

            private void RecalculatePossibilities()
            {
                if (RiskSourcesValues == null || RiskEventsValues == null)
                    return;


                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    double prob = 0;

                    for (int j = 0; j < RiskSourcesValues[i].Length; j++)
                    {
                        if (RiskSourcesValues[i][j].Key == 1)
                            prob += RiskSourcesValues[i][j].Value;
                    }
                    
                    RiskSourcesProbabilities[i] = new KeyValuePair<string, double>(RiskSources[i].Key, prob);
                }   

                

                for (int i = 0; i < RiskSourcesProbabilities.Length; i ++)
                {
                    var tempKey = RiskSourcesProbabilities[i].Key;
                    var tempValue = RiskSourcesProbabilities[i].Value;
                    RiskSourcesProbabilities[i] = new KeyValuePair<string, double>(tempKey, tempValue / RiskSourcesTotalCount);
                }

            //for (int i = 0; i < RiskTypesCount; ++i)
            //{
            //double prob = (double)RiskSourcesValues[i].Count(value => value == 1) / RiskSourcesTotalCount;
            //    RiskSourcesProbabilities[i] = new KeyValuePair<string, double>(RiskSources[i].Key, prob);
            //}

                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    double prob = 0;

                    for (int j = 0; j < RiskEventsValues[i].Length; j++)
                    {
                        if (RiskEventsValues[i][j].Key == 1)
                            prob += RiskEventsValues[i][j].Value;
                    }

                    RiskEventsProbabilities[i] = new KeyValuePair<string, double>(RiskSources[i].Key, prob);

                }

                for (int i = 0; i < RiskEventsProbabilities.Length; i++)
                {
                    var tempKey = RiskEventsProbabilities[i].Key;
                    var tempValue = RiskEventsProbabilities[i].Value;
                    RiskEventsProbabilities[i] = new KeyValuePair<string, double>(tempKey, tempValue / RiskEventsTotalCount);
                }

            //for (int i = 0; i < RiskTypesCount; ++i)
            //{
            //   double prob = (double)RiskEventsValues[i].Count(value => value == 1) / RiskEventsTotalCount;
            //    RiskEventsProbabilities[i] = new KeyValuePair<string, double>(RiskEvents[i].Key, prob);
            //}
        }

        private void AltRecalculatePossibilities()
        {
            if (RiskSourcesValues == null || RiskEventsValues == null)
                return;


            for (int i = 0; i < RiskTypesCount; ++i)
            {
                double prob = (double)altRiskSourcesValues[i].Count(value => value == 1) / RiskSourcesTotalCount;
                altRiskSourcesProbabilities[i] = new KeyValuePair<string, double>(RiskSources[i].Key, prob);
            }

            for (int i = 0; i < RiskTypesCount; ++i)
            {
                double prob = (double)altRiskEventsValues[i].Count(value => value == 1) / RiskEventsTotalCount;
                altRiskEventsProbabilities[i] = new KeyValuePair<string, double>(RiskEvents[i].Key, prob);
            }
        }
        private void RecalculateER()
            {
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        ER[i][j] = ExpertsGrades[i][j].Average();
                    }
                }
            }
            private void RecalculateVRER()
            {
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        VRER[i][j] = ER[i][j] * LRER[i][j];
                    }
                }
            }
            private void RecalculateEVER()
            {
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        for (int k = 0; k < ExpertsCount; ++k)
                        {
                            EVER[i][j][k] = ExpertsGrades[i][j][k] * PreventionMethodsEffectiveness[SelectedPreventions[i][j]];
                        }
                    }
                }
            }
            private void RecalculateERPER()
            {
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        ERPER[i][j] = EVER[i][j].Average();
                    }
                }
            }
            private void RecalculateEVRER()
            {
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        EVRER[i][j] = ERPER[i][j] * ELRER[i][j];
                    }
                }
            }
            public RiskManager()
            {

            
            
                    //{ 0.29, 0.49, 0.38, 0.49, 0.66, 0.46, 0.05 }, 
                    //{ 0.33, 0.79, 0.07 }};

                    //{ 0.43, 0.85, 0.21 },
                    //{ 0.26, 0.72, 0.39, 0.44, 0.95 }
                

                RiskSourcesValues = new List<KeyValuePair<int, double>[]>();


                RiskSourcesValues.Add(
                    new KeyValuePair<int, double>[]
                    {
                        new KeyValuePair<int, double>(1, 0.75),
                        new KeyValuePair<int, double>(1, 0.69),
                        new KeyValuePair<int, double>(1, 0.10),
                        new KeyValuePair<int, double>(1, 0.40),
                        new KeyValuePair<int, double>(1, 0.50),
                        new KeyValuePair<int, double>(1, 0.78),
                        new KeyValuePair<int, double>(1, 0.13)
                    });

                RiskSourcesValues.Add(
                    new KeyValuePair<int, double>[]
                    {
                        new KeyValuePair<int, double>(1, 0.91),
                        new KeyValuePair<int, double>(1, 0.21),
                        new KeyValuePair<int, double>(1, 0.47)
                    });

                RiskSourcesValues.Add(
                    new KeyValuePair<int, double>[]
                    {
                        new KeyValuePair<int, double>(1, 0.21),
                        new KeyValuePair<int, double>(1, 0.91),
                        new KeyValuePair<int, double>(1, 0.36)
                    });


                RiskSourcesValues.Add(
                    new KeyValuePair<int, double>[]
                    {
                        new KeyValuePair<int, double>(1, 0.04),
                        new KeyValuePair<int, double>(1, 0.02),
                        new KeyValuePair<int, double>(1, 0.01),
                        new KeyValuePair<int, double>(1, 0.77),
                        new KeyValuePair<int, double>(1, 0.83)
                    });





            altRiskSourcesValues = new int[RiskTypesCount][];
            for (int i = 0; i < RiskTypesCount; ++i)
            {
                altRiskSourcesValues[i] = new int[RiskSources[i].Value.Count()];
                for (int j = 0; j < RiskSources[i].Value.Count(); ++j)
                {
                    altRiskSourcesValues[i][j] = 1;
                }
            }


            RiskEventsValues = new List<KeyValuePair<int, double>[]>();


            RiskEventsValues.Add(
                    new KeyValuePair<int, double>[]
                    {
                        new KeyValuePair<int, double>(1, 0.75),
                        new KeyValuePair<int, double>(1, 0.62),
                        new KeyValuePair<int, double>(1, 0.74),
                        new KeyValuePair<int, double>(1, 0.85),
                        new KeyValuePair<int, double>(1, 0.41),
                        new KeyValuePair<int, double>(1, 0.72),
                        new KeyValuePair<int, double>(1, 0.39),
                        new KeyValuePair<int, double>(1, 0.90),
                        new KeyValuePair<int, double>(1, 0.60),
                        new KeyValuePair<int, double>(1, 0.57),
                        new KeyValuePair<int, double>(1, 0.30)
                    });

            RiskEventsValues.Add(
                new KeyValuePair<int, double>[]
                {
                        new KeyValuePair<int, double>(1, 0.45),
                        new KeyValuePair<int, double>(1, 0.24),
                        new KeyValuePair<int, double>(1, 0.37),
                        new KeyValuePair<int, double>(1, 0.52),
                        new KeyValuePair<int, double>(1, 0.46),
                        new KeyValuePair<int, double>(1, 0.35),
                        new KeyValuePair<int, double>(1, 0.49)
                });

            RiskEventsValues.Add(
                new KeyValuePair<int, double>[]
                {
                        new KeyValuePair<int, double>(1, 0.99),
                        new KeyValuePair<int, double>(1, 0.81),
                        new KeyValuePair<int, double>(1, 0.28),
                        new KeyValuePair<int, double>(1, 0.48),
                        new KeyValuePair<int, double>(1, 0.44),
                        new KeyValuePair<int, double>(1, 0.48),
                        new KeyValuePair<int, double>(1, 0.54),
                        new KeyValuePair<int, double>(1, 0.21),
                        new KeyValuePair<int, double>(1, 0.62)
                });


            RiskEventsValues.Add(
                new KeyValuePair<int, double>[]
                {
                        new KeyValuePair<int, double>(1, 0.48),
                        new KeyValuePair<int, double>(1, 0.75),
                        new KeyValuePair<int, double>(1, 0.34),
                        new KeyValuePair<int, double>(1, 0.60),
                        new KeyValuePair<int, double>(1, 0.76),
                        new KeyValuePair<int, double>(1, 0.81),
                        new KeyValuePair<int, double>(1, 0.34),
                        new KeyValuePair<int, double>(1, 0.24),
                        new KeyValuePair<int, double>(1, 0.92),
                        new KeyValuePair<int, double>(1, 0.56),
                        new KeyValuePair<int, double>(1, 0.78),
                        new KeyValuePair<int, double>(1, 0.49),
                        new KeyValuePair<int, double>(1, 0.89),
                        new KeyValuePair<int, double>(1, 0.48)
                });

            altRiskEventsValues = new int[RiskTypesCount][];
            for (int i = 0; i < RiskTypesCount; ++i)
            {
                altRiskEventsValues[i] = new int[RiskEvents[i].Value.Count()];
                for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                {
                    altRiskEventsValues[i][j] = 1;
                }
            }

            Random rand = new Random();

                for (int i = 0; i < ExpertsCount; ++i)
                {
                    ExpertsWage[i] = rand.Next(5) + 5;
                }

                ExpertsGrades = new double[RiskTypesCount][][];
                WagedExpertsGrade = new double[RiskTypesCount][][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    ExpertsGrades[i] = new double[RiskEvents[i].Value.Count()][];
                    WagedExpertsGrade[i] = new double[RiskEvents[i].Value.Count()][];
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        ExpertsGrades[i][j] = new double[ExpertsCount];
                        WagedExpertsGrade[i][j] = new double[ExpertsCount];
                        for (int k = 0; k < ExpertsCount; ++k)
                        {
                            ExpertsGrades[i][j][k] = rand.NextDouble() * rand.NextDouble();
                            WagedExpertsGrade[i][j][k] = ExpertsGrades[i][j][k] * ExpertsWage[k];
                        }
                    }
                }

                ER = new double[RiskTypesCount][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    ER[i] = new double[RiskEvents[i].Value.Count()];
                }
                RecalculateER();


                LRER = new double[RiskTypesCount][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    LRER[i] = new double[RiskEvents[i].Value.Count()];
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        LRER[i][j] = rand.NextDouble();
                    }
                }

                VRER = new double[RiskTypesCount][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    VRER[i] = new double[RiskEvents[i].Value.Count()];
                }
                RecalculateVRER();


                SelectedPreventions = new int[RiskTypesCount][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    SelectedPreventions[i] = new int[RiskEvents[i].Value.Count()];
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        SelectedPreventions[i][j] = 0;
                    }
                }

                EVER = new double[RiskTypesCount][][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    EVER[i] = new double[RiskEvents[i].Value.Count()][];
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        EVER[i][j] = new double[ExpertsCount];
                    }
                }
                RecalculateEVER();

                ERPER = new double[RiskTypesCount][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    ERPER[i] = new double[RiskEvents[i].Value.Count()];
                }
                RecalculateERPER();


                ELRER = new double[RiskTypesCount][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    ELRER[i] = new double[RiskEvents[i].Value.Count()];
                    for (int j = 0; j < RiskEvents[i].Value.Count(); ++j)
                    {
                        ELRER[i][j] = rand.NextDouble();
                    }
                }

                EVRER = new double[RiskTypesCount][];
                for (int i = 0; i < RiskTypesCount; ++i)
                {
                    EVRER[i] = new double[RiskEvents[i].Value.Count()];
                }
                RecalculateEVRER();
                RecalculatePossibilities();

            //---------------------------------

            AltRecalculatePossibilities();
            //------------------------------------------
            }
            public void ChangeRiskSourceValue(int type, int risk, int value)
            {
                var temp = RiskSourcesValues[type][risk].Value;
                RiskSourcesValues[type][risk] = new KeyValuePair<int, double>(value, temp);
                RecalculatePossibilities();
            }
            public void altChangeRiskSourceValue(int type, int risk, int value)
            {
                altRiskSourcesValues[type][risk] = value;
                AltRecalculatePossibilities();
            }
            public void ChangeRiskEventsValue(int type, int risk, int value)
            {
                var temp = RiskEventsValues[type][risk].Value;
                RiskEventsValues[type][risk] = new KeyValuePair<int, double>(value, temp);
                RecalculatePossibilities();
            }
            public void altChangeRiskEventsValue(int type, int risk, int value)
            {
                altRiskEventsValues[type][risk] = value;
                AltRecalculatePossibilities();
            }

            public void ChangeExpertGrade(int type, int risk, int expert, double grade)
            {
                ExpertsGrades[type][risk][expert] = grade;
                RecalculateER();
                RecalculateVRER();
                RecalculateEVER();
                RecalculateERPER();
                RecalculateEVRER();
            }
            public void ChangeLRER(int type, int risk, double loss)
            {
                LRER[type][risk] = loss;
                RecalculateVRER();
            }
            public void ChangeSelectedPrevention(int type, int risk, int prevention)
            {
                SelectedPreventions[type][risk] = prevention;
                RecalculateEVER();
                RecalculateERPER();
                RecalculateEVRER();
            }
            public void ChangeEVER(int type, int risk, int expert, double grade)
            {
                EVER[type][risk][expert] = grade;
                RecalculateERPER();
                RecalculateEVRER();
            }
            public void ChangeELRER(int type, int risk, double loss)
            {
                ELRER[type][risk] = loss;
                RecalculateEVRER();
            }
        }
    }



