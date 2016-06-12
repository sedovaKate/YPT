namespace YouPersonalTrainer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YouPersonalTrainer.Models;
    using YouPersonalTrainer.Enum;

    internal sealed class Configuration : DbMigrationsConfiguration<YouPersonalTrainer.Models.YPTDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(YouPersonalTrainer.Models.YPTDB context)
        {
            var collection = context.Articles;
            foreach (var item in collection)
            {
                context.Articles.Remove(item);
            }
            context.Articles.AddOrUpdate(new Article { Title = "ПОГОВОРИМ О КАЛОРИЯХ", Footnote = "Одна из самых главных ловушек подсчета калорий – безразличие к составу рациона.", Text = "Не все калории рождены равными, т. е. калория калории рознь.  Каждый вид нутриентов (белки, жиры или углеводы) запускает цепочку гормональных реакций, каждая из которых приводит к определенному результату.  Одни гормоны дают сигнал «Выпускай сахар!», другие — «Откладывай жир про запас!», а третьи — «Строй мышцы!».  Множество научных статей доказывает, что при одинаковом количестве калорий именно состав рациона может существенно повлиять на потерю веса и на соотношение мышечной массы и жировой прослойки.", Category = ArticlesTypes.Diet, Id = 1 });
            context.Articles.AddOrUpdate(new Article { Title = "СПОРТ И ПОДСЧЕТ КАЛОРИЙ", Footnote = "Негативное отношение к спорту как к неприятной обязанности делает его неэффективным и, скорее всего, временным явлением в жизни человека", Text = "Спорт тоже может превратиться в западню для человека, считающего калории — он становится индульгенцией и дает установку, что еду можно отработать. Такой подход делает любую намеренную физическую активность наказанием и превращает спорт во что-то, что человек вынужден делать, чтобы компенсировать съеденное или создать запас на грядущие дни.", Category = ArticlesTypes.Diet, Id = 2 });
            context.Articles.AddOrUpdate(new Article { Title = "КАЛЬКУЛЯТОРЫ", Text = "Одно из самых больших заблуждений относительно калорий заключается в том, что, по мнению многих, «нас всех можно подсчитать» и выдать цифру, которая будет соответствовать нашим потребностям. Однако научные наблюдения указывают на обратное.", Category = ArticlesTypes.Diet, Id = 3 });
            context.Articles.AddOrUpdate(new Article { Title = "ВОДНЫЙ БАЛАНС ЧЕЛОВЕКА", Footnote = "Нехватка воды приводит к обезвоживанию, уменьшению объема крови в организме, кислородному голоданию и даже съёживанию клеток.", Text = "Общее содержание жидкости в организме взрослого человека составляет 60-65% от его массы.Все химические процессы в организме протекают в присутствии этого уникального растворителя, и в нем же содержится большая часть полезных веществ, потребляемых с пищей. Она участвует в жировом, углеводном и тепловом обменах – процессах, напрямую влияющих на поддержание хорошей физической формы. В воде растворяются кислород и углекислый газ, так что даже дыхание без нее невозможно.Вынужденные потери воды резко снижают работоспособность организма в целом и отдельных органов и систем. Нехватка воды приводит к обезвоживанию, уменьшению объема крови в организме, кислородному голоданию и даже съёживанию клеток.", Category = ArticlesTypes.Diet, Id = 4 });
            context.Articles.AddOrUpdate(new Article { Title = "ВОДА И ПРИЕМЫ ПИЩИ", Footnote = "Врачи однозначно утверждают, что нет никаких причин опасаться, что вода разбавляет желудочный сок и тем самым мешает пищеварению.", Text = "Также важно коснуться вопроса употребления воды во время приема пищи.Врачи однозначно утверждают, что нет никаких причин опасаться, что вода разбавляет желудочный сок и тем самым мешает пищеварению.За много лет накопилось достаточно наблюдений за пациентами, находящимися в больнице, у которых измеряли кислотность в желудке натощак, после приема пищи или после употребления воды. Все они указывают на то, что кислотность практически не меняется, даже когда больные пьют воду после суточного поста.", Category = ArticlesTypes.Diet, Id = 5 });
            context.Articles.AddOrUpdate(new Article { Title = "ПИТЬЕВОЙ РЕЖИМ ВО ВРЕМЯ  ЗАНЯТИЙ СПОРТОМ", Footnote = "Результаты проведенных исследований показывают, что «сухие» занятия любым спортом на 10% менее эффективны.", Text = "Во время занятий спортом за счет мышечной работы, учащенного дыхания и потоотделения человек теряет значительное количество жидкости. Это может повлечь за собой серьезные нарушения работы почек и сердечно-сосудистой системы. Соответственно, чтобы избежать негативных последствий, нужно следить за водным балансом во время физической нагрузки.", Category = ArticlesTypes.Diet, Id = 6 });
            context.Articles.AddOrUpdate(new Article { Title = "РАЗМЕР ПОРЦИИ", Text = "Известно, что в тарелке должно быть еды ровно столько, чтобы не выйти из-за стола голодными, но и не переесть. Как этого добиться? Ведь порой всё равно трудно удержаться от лишнего кусочка пирога. ", Category = ArticlesTypes.Diet, Id = 7 });
            context.Articles.AddOrUpdate(new Article { Title = "РЕАКЦИЯ ОРГАНИЗМА НА АЛКОГОЛЬ", Text = "Подавляющее большинство населения так или иначе пробовало употреблять спиртные напитки и делает это с некоторой периодичностью. Существует немало людей, полностью отказавшихся от алкоголя, но еще больше тех, кто не представляет жизнь без спиртных напитков. Давайте разберемся, как именно алкоголь влияет на нас.", Category = ArticlesTypes.Diet, Id = 8 });
            
            context.Product.AddOrUpdate(new Product { Id=1, Title = "Морковь", Category = ProductsType.Vegerable, Protein = 0.9, Fat = 0.2, Carbohidrate = 10, Energy = 41 });             
            context.Product.AddOrUpdate(new Product { Id=2 , Title = "Огурец", Category = ProductsType.Vegerable , Protein = 0.8, Fat = 0.1, Carbohidrate = 2.5, Energy =14 });
            context.Product.AddOrUpdate(new Product { Id=3 , Title = "Кабачок", Category = ProductsType.Vegerable , Protein = 0.6, Fat = 0.3, Carbohidrate = 4.6, Energy = 24});
            context.Product.AddOrUpdate(new Product { Id=4 , Title = "Апельсин", Category = ProductsType.Fruit , Protein = 0.9, Fat = 0.2, Carbohidrate = 8.1, Energy = 36});
            context.Product.AddOrUpdate(new Product { Id=5 , Title = "Ананас", Category = ProductsType.Fruit , Protein = 0.3, Fat = 0.1, Carbohidrate = 11.8, Energy = 52});
            context.Product.AddOrUpdate(new Product { Id=6 , Title = "Виноград", Category = ProductsType.Fruit, Protein = 0.6, Fat = 0.6, Carbohidrate = 15.4, Energy = 72});
            context.Product.AddOrUpdate(new Product { Id=7 , Title = "Гречневая крупа", Category = ProductsType.Porrage , Protein = 12.6, Fat = 3.3, Carbohidrate = 57.1, Energy = 308});
            context.Product.AddOrUpdate(new Product { Id=8 , Title = "Пшенная крупа", Category = ProductsType.Porrage, Protein = 11.5, Fat = 3.3, Carbohidrate = 66.5, Energy = 342});
            context.Product.AddOrUpdate(new Product { Id=9 , Title = "Манная крупа", Category = ProductsType.Porrage , Protein = 10.3, Fat = 1, Carbohidrate = 70.6, Energy = 333});
            context.Product.AddOrUpdate(new Product { Id=10 , Title = "Говядина", Category = ProductsType.Protein, Protein = 17, Fat = 14.4, Carbohidrate = 0, Energy = 198});
            context.Product.AddOrUpdate(new Product { Id=11 , Title = "Цыпленок", Category = ProductsType.Protein, Protein = 17.6, Fat = 12.3, Carbohidrate = 0.4, Energy = 183});
            context.Product.AddOrUpdate(new Product { Id=12 , Title = "Свиная грудинка", Category= ProductsType.Protein, Protein = 9.34, Fat = 53.01, Carbohidrate = 0, Energy = 518});
           /* context.Product.AddOrUpdate(new Product { Id=13 , Title = "", Category =4 , Protein = , Fat = , Carbohidrate = , Energy = });
             context.Product.AddOrUpdate(new Product { Id=14 , Title = "", Category =4 , Protein = , Fat = , Carbohidrate = , Energy = });
             context.Product.AddOrUpdate(new Product { Id=15 , Title = "", Category =4 , Protein = , Fat = , Carbohidrate = , Energy = });
             context.Product.AddOrUpdate(new Product { Id=16 , Title = "", Category =5 , Protein = , Fat = , Carbohidrate = , Energy = });
             context.Product.AddOrUpdate(new Product { Id=17 , Title = "", Category =5 , Protein = , Fat = , Carbohidrate = , Energy = });
             context.Product.AddOrUpdate(new Product { Id=18 , Title = "", Category =5 , Protein = , Fat = , Carbohidrate = , Energy = });
             context.Product.AddOrUpdate(new Product { Id=19 , Title = "", Category =6 , Protein = , Fat = , Carbohidrate = , Energy = });
             context.Product.AddOrUpdate(new Product { Id=20 , Title = "", Category =6 , Protein = , Fat = , Carbohidrate = , Energy = });*/
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
