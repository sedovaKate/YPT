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
            context.Articles.AddOrUpdate(new Article { Title = "��������� � ��������", Footnote = "���� �� ����� ������� ������� �������� ������� � ����������� � ������� �������.", Text = "�� ��� ������� ������� �������, �. �. ������� ������� �����.  ������ ��� ���������� (�����, ���� ��� ��������) ��������� ������� ������������ �������, ������ �� ������� �������� � ������������� ����������.  ���� ������� ���� ������ ��������� �����!�, ������ � ����������� ��� ��� �����!�, � ������ � ������ �����!�.  ��������� ������� ������ ����������, ��� ��� ���������� ���������� ������� ������ ������ ������� ����� ����������� �������� �� ������ ���� � �� ����������� �������� ����� � ������� ���������.", Category = ArticlesTypes.Diet, Id = 1 });
            context.Articles.AddOrUpdate(new Article { Title = "����� � ������� �������", Footnote = "���������� ��������� � ������ ��� � ���������� ����������� ������ ��� ������������� �, ������ �����, ��������� �������� � ����� ��������", Text = "����� ���� ����� ������������ � ������� ��� ��������, ���������� ������� � �� ���������� ������������� � ���� ���������, ��� ��� ����� ����������. ����� ������ ������ ����� ���������� ���������� ���������� ���������� � ���������� ����� �� ���-��, ��� ������� �������� ������, ����� �������������� ��������� ��� ������� ����� �� �������� ���.", Category = ArticlesTypes.Diet, Id = 2 });
            context.Articles.AddOrUpdate(new Article { Title = "������������", Text = "���� �� ����� ������� ����������� ������������ ������� ����������� � ���, ���, �� ������ ������, ���� ���� ����� ����������� � ������ �����, ������� ����� ��������������� ����� ������������. ������ ������� ���������� ��������� �� ��������.", Category = ArticlesTypes.Diet, Id = 3 });
            context.Articles.AddOrUpdate(new Article { Title = "������ ������ ��������", Footnote = "�������� ���� �������� � �������������, ���������� ������ ����� � ���������, ������������ ��������� � ���� ���������� ������.", Text = "����� ���������� �������� � ��������� ��������� �������� ���������� 60-65% �� ��� �����.��� ���������� �������� � ��������� ��������� � ����������� ����� ����������� ������������, � � ��� �� ���������� ������� ����� �������� �������, ������������ � �����. ��� ��������� � �������, ���������� � �������� ������� � ���������, �������� �������� �� ����������� ������� ���������� �����. � ���� ������������ �������� � ���������� ���, ��� ��� ���� ������� ��� ��� ����������.����������� ������ ���� ����� ������� ����������������� ��������� � ����� � ��������� ������� � ������. �������� ���� �������� � �������������, ���������� ������ ����� � ���������, ������������ ��������� � ���� ���������� ������.", Category = ArticlesTypes.Diet, Id = 4 });
            context.Articles.AddOrUpdate(new Article { Title = "���� � ������ ����", Footnote = "����� ���������� ����������, ��� ��� ������� ������ ���������, ��� ���� ���������� ���������� ��� � ��� ����� ������ �����������.", Text = "����� ����� ��������� ������� ������������ ���� �� ����� ������ ����.����� ���������� ����������, ��� ��� ������� ������ ���������, ��� ���� ���������� ���������� ��� � ��� ����� ������ �����������.�� ����� ��� ���������� ���������� ���������� �� ����������, ������������ � ��������, � ������� �������� ����������� � ������� �������, ����� ������ ���� ��� ����� ������������ ����. ��� ��� ��������� �� ��, ��� ����������� ����������� �� ��������, ���� ����� ������� ���� ���� ����� ��������� �����.", Category = ArticlesTypes.Diet, Id = 5 });
            context.Articles.AddOrUpdate(new Article { Title = "�������� ����� �� �����  ������� �������", Footnote = "���������� ����������� ������������ ����������, ��� ������ ������� ����� ������� �� 10% ����� ����������.", Text = "�� ����� ������� ������� �� ���� �������� ������, ���������� ������� � ������������� ������� ������ ������������ ���������� ��������. ��� ����� ������� �� ����� ��������� ��������� ������ ����� � ��������-���������� �������. ��������������, ����� �������� ���������� �����������, ����� ������� �� ������ �������� �� ����� ���������� ��������.", Category = ArticlesTypes.Diet, Id = 6 });
            context.Articles.AddOrUpdate(new Article { Title = "������ ������", Text = "��������, ��� � ������� ������ ���� ��� ����� �������, ����� �� ����� ��-�� ����� ���������, �� � �� ��������. ��� ����� ��������? ���� ����� �� ����� ������ ���������� �� ������� ������� ������. ", Category = ArticlesTypes.Diet, Id = 7 });
            context.Articles.AddOrUpdate(new Article { Title = "������� ��������� �� ��������", Text = "����������� ����������� ��������� ��� ��� ����� ��������� ����������� �������� ������� � ������ ��� � ��������� ��������������. ���������� ������ �����, ��������� ������������ �� ��������, �� ��� ������ ���, ��� �� ������������ ����� ��� �������� ��������. ������� ����������, ��� ������ �������� ������ �� ���.", Category = ArticlesTypes.Diet, Id = 8 });
            
            context.Product.AddOrUpdate(new Product { Id=1, Title = "�������", Category = ProductsType.Vegerable, Protein = 0.9, Fat = 0.2, Carbohidrate = 10, Energy = 41 });             
            context.Product.AddOrUpdate(new Product { Id=2 , Title = "������", Category = ProductsType.Vegerable , Protein = 0.8, Fat = 0.1, Carbohidrate = 2.5, Energy =14 });
            context.Product.AddOrUpdate(new Product { Id=3 , Title = "�������", Category = ProductsType.Vegerable , Protein = 0.6, Fat = 0.3, Carbohidrate = 4.6, Energy = 24});
            context.Product.AddOrUpdate(new Product { Id=4 , Title = "��������", Category = ProductsType.Fruit , Protein = 0.9, Fat = 0.2, Carbohidrate = 8.1, Energy = 36});
            context.Product.AddOrUpdate(new Product { Id=5 , Title = "������", Category = ProductsType.Fruit , Protein = 0.3, Fat = 0.1, Carbohidrate = 11.8, Energy = 52});
            context.Product.AddOrUpdate(new Product { Id=6 , Title = "��������", Category = ProductsType.Fruit, Protein = 0.6, Fat = 0.6, Carbohidrate = 15.4, Energy = 72});
            context.Product.AddOrUpdate(new Product { Id=7 , Title = "��������� �����", Category = ProductsType.Porrage , Protein = 12.6, Fat = 3.3, Carbohidrate = 57.1, Energy = 308});
            context.Product.AddOrUpdate(new Product { Id=8 , Title = "������� �����", Category = ProductsType.Porrage, Protein = 11.5, Fat = 3.3, Carbohidrate = 66.5, Energy = 342});
            context.Product.AddOrUpdate(new Product { Id=9 , Title = "������ �����", Category = ProductsType.Porrage , Protein = 10.3, Fat = 1, Carbohidrate = 70.6, Energy = 333});
            context.Product.AddOrUpdate(new Product { Id=10 , Title = "��������", Category = ProductsType.Protein, Protein = 17, Fat = 14.4, Carbohidrate = 0, Energy = 198});
            context.Product.AddOrUpdate(new Product { Id=11 , Title = "��������", Category = ProductsType.Protein, Protein = 17.6, Fat = 12.3, Carbohidrate = 0.4, Energy = 183});
            context.Product.AddOrUpdate(new Product { Id=12 , Title = "������ ��������", Category= ProductsType.Protein, Protein = 9.34, Fat = 53.01, Carbohidrate = 0, Energy = 518});
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
