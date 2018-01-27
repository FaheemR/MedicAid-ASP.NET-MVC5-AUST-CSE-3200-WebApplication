 namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            ///seeding users
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'48501445-c7e2-4905-af26-f1815da6ee39', N'admin@medicaid.com', 0, N'AB7Lm4fhkzwneJGZ9OiLlJ6MPdgbAzhoDMSlQPYQJQ5dgfyQ1NGI9OLVXUTjSIWrGA==', N'3ec8bb70-4900-4819-af3b-603c887d3e14', NULL, 0, 0, NULL, 1, 0, N'admin@medicaid.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4e941571-d15c-4f48-8ced-d3f3348c7e50', N'receptionist@medicaid.com', 0, N'AB5sXlJ2Z78vrgzqwAfqqmjJgO9AWdFqyLtJDjG8+rUrfa6GgrEKaoTnCT47Tm3J/Q==', N'13db9efc-2a4e-40fe-a6a2-c72a162329fc', NULL, 0, 0, NULL, 1, 0, N'receptionist@medicaid.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'df9bb9c0-eb5c-48fa-a1a2-4b36f7611298', N'patient@medicaid.com', 0, N'AOtG9PFe5OO9SyLlglBSNnxjh/OL146XCXUCe2taCaB7dATwXJ7UJLN61bPtsvsixw==', N'7d417c12-c73c-42f0-a075-9c27942aae90', NULL, 0, 0, NULL, 1, 0, N'patient@medicaid.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'365d8692-1e2c-4009-9bbf-7fae4ac4dcd2', N'ADMIN')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'eb7740a9-54c8-45ce-989a-38e26631d233', N'RECEPTIONIST')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'48501445-c7e2-4905-af26-f1815da6ee39', N'365d8692-1e2c-4009-9bbf-7fae4ac4dcd2')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4e941571-d15c-4f48-8ced-d3f3348c7e50', N'eb7740a9-54c8-45ce-989a-38e26631d233')

");
        }
        
        public override void Down()
        {
        }
    }
}
