namespace YouPersonalTrainer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YouPersonalTrainer.Models;

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
            context.Articles.AddOrUpdate(new Article { Title = "��������� � ��������", Footnote = "���� �� ����� ������� ������� �������� ������� � ����������� � ������� �������.", Text = "�� ��� ������� ������� �������, �. �. ������� ������� �����.  ������ ��� ���������� (�����, ���� ��� ��������) ��������� ������� ������������ �������, ������ �� ������� �������� � ������������� ����������.  ���� ������� ���� ������ ��������� �����!�, ������ � ����������� ��� ��� �����!�, � ������ � ������ �����!�.  ��������� ������� ������ ����������, ��� ��� ���������� ���������� ������� ������ ������ ������� ����� ����������� �������� �� ������ ���� � �� ����������� �������� ����� � ������� ���������.", Category = 0, Id = 1 });
            context.Articles.AddOrUpdate(new Article { Title = "����� � ������� �������", Footnote = "���������� ��������� � ������ ��� � ���������� ����������� ������ ��� ������������� �, ������ �����, ��������� �������� � ����� ��������", Text = "����� ���� ����� ������������ � ������� ��� ��������, ���������� ������� � �� ���������� ������������� � ���� ���������, ��� ��� ����� ����������. ����� ������ ������ ����� ���������� ���������� ���������� ���������� � ���������� ����� �� ���-��, ��� ������� �������� ������, ����� �������������� ��������� ��� ������� ����� �� �������� ���.", Category = 0, Id = 2 });
            context.Articles.AddOrUpdate(new Article { Title = "������������", Text = "���� �� ����� ������� ����������� ������������ ������� ����������� � ���, ���, �� ������ ������, ���� ���� ����� ����������� � ������ �����, ������� ����� ��������������� ����� ������������. ������ ������� ���������� ��������� �� ��������.", Category = 0, Id = 3 });
            context.Articles.AddOrUpdate(new Article { Title = "������ ������ ��������", Footnote = "�������� ���� �������� � �������������, ���������� ������ ����� � ���������, ������������ ��������� � ���� ���������� ������.", Text = "����� ���������� �������� � ��������� ��������� �������� ���������� 60-65% �� ��� �����.��� ���������� �������� � ��������� ��������� � ����������� ����� ����������� ������������, � � ��� �� ���������� ������� ����� �������� �������, ������������ � �����. ��� ��������� � �������, ���������� � �������� ������� � ���������, �������� �������� �� ����������� ������� ���������� �����. � ���� ������������ �������� � ���������� ���, ��� ��� ���� ������� ��� ��� ����������.����������� ������ ���� ����� ������� ����������������� ��������� � ����� � ��������� ������� � ������. �������� ���� �������� � �������������, ���������� ������ ����� � ���������, ������������ ��������� � ���� ���������� ������.", Category = 0, Id = 4 });
            context.Articles.AddOrUpdate(new Article { Title = "���� � ������ ����", Footnote = "����� ���������� ����������, ��� ��� ������� ������ ���������, ��� ���� ���������� ���������� ��� � ��� ����� ������ �����������.", Text = "����� ����� ��������� ������� ������������ ���� �� ����� ������ ����.����� ���������� ����������, ��� ��� ������� ������ ���������, ��� ���� ���������� ���������� ��� � ��� ����� ������ �����������.�� ����� ��� ���������� ���������� ���������� �� ����������, ������������ � ��������, � ������� �������� ����������� � ������� �������, ����� ������ ���� ��� ����� ������������ ����. ��� ��� ��������� �� ��, ��� ����������� ����������� �� ��������, ���� ����� ������� ���� ���� ����� ��������� �����.", Category = 0, Id = 5 });
            context.Articles.AddOrUpdate(new Article { Title = "�������� ����� �� �����  ������� �������", Footnote = "���������� ����������� ������������ ����������, ��� ������ ������� ����� ������� �� 10% ����� ����������.", Text = "�� ����� ������� ������� �� ���� �������� ������, ���������� ������� � ������������� ������� ������ ������������ ���������� ��������. ��� ����� ������� �� ����� ��������� ��������� ������ ����� � ��������-���������� �������. ��������������, ����� �������� ���������� �����������, ����� ������� �� ������ �������� �� ����� ���������� ��������.", Category = 0, Id = 6 });
            context.Articles.AddOrUpdate(new Article { Title = "������ ������", Text = "��������, ��� � ������� ������ ���� ��� ����� �������, ����� �� ����� ��-�� ����� ���������, �� � �� ��������. ��� ����� ��������? ���� ����� �� ����� ������ ���������� �� ������� ������� ������. ", Category = 0, Id = 7 });
            context.Articles.AddOrUpdate(new Article { Title = "������� ��������� �� ��������", Text = "����������� ����������� ��������� ��� ��� ����� ��������� ����������� �������� ������� � ������ ��� � ��������� ��������������. ���������� ������ �����, ��������� ������������ �� ��������, �� ��� ������ ���, ��� �� ������������ ����� ��� �������� ��������. ������� ����������, ��� ������ �������� ������ �� ���.", Category = 0, Id = 8 });
            context.Trainings.AddOrUpdate(new Training { Id = 1, Title="gpgp" });
            context.Trainings.AddOrUpdate(new Training { Id = 2, Title = "lol", Text = "podfopsri" });
            context.Product.AddOrUpdate(new Product { Id = 1, Title = "Carrot", Category = 0, Protein = 0.9, Fat = 0.2, Carbohidrate = 10, Energy = 41 });             /*context.Articles.AddOrUpdate(new Article { Title = "", Text = "", Category = 0, Id = 9 });
           context.Articles.AddOrUpdate(new Article { Title = "", Text = "", Category = 0, Id = 10 });*/
           
            

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
