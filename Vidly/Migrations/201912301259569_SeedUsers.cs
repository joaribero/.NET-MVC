namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ce9f0978-cdd8-422b-b803-0d41ed461f70', N'admin@vidly.com', 0, N'ANVxZqHEPmKASp+73tjWA6Qk+gZzvRdZpa9aBfbrUOvBn4F+TmI0s5LGq6hgwnNDJw==', N'0f23b221-9627-49e9-b66e-e77c7da2a9c6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'de122066-7008-4ee2-a681-27a0f442a180', N'guest@vidly.com', 0, N'ADmukTKD6mnMPnz348OszSwHizlzx/P38qpYeJ3Gul6KodwQgRTGALr+3ga4f8qHXw==', N'32c13473-2471-4859-bff3-1f8224aca353', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ce9f0978-cdd8-422b-b803-0d41ed461f70', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
