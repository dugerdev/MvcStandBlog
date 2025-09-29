# WA_MVC_StandBlog

A modern and user-friendly blog application. Developed using ASP.NET Core MVC and Entity Framework Core.

> **📌 This is the Basic Version** - For the full-featured version with admin panel, user management, and advanced features, check out the [StandBlog](https://github.com/dugerdev/StandBlog) repository.

## 🚀 Features (Basic Version)

- **Blog Management**: Create, edit and view blog posts
- **Category System**: Organize blog posts into categories
- **Tag System**: Organize blog posts with tags
- **Comment System**: Allow visitors to comment on blog posts
- **Contact Form**: Allow visitors to contact the site administrator
- **Responsive Design**: Perfect appearance on mobile and desktop devices
- **Modern UI**: Clean and user-friendly interface

### 🔥 Full Version Features
For advanced features like admin panel, user authentication, role management, and more, visit the [StandBlog](https://github.com/dugerdev/StandBlog) repository.

## 🛠️ Technologies

- **.NET 8.0** - Modern .NET platform
- **ASP.NET Core MVC** - Web application framework
- **Entity Framework Core 9.0** - ORM (Object-Relational Mapping)
- **SQL Server** - Database
- **Bootstrap** - CSS framework
- **jQuery** - JavaScript library

## 📋 Requirements

- .NET 8.0 SDK
- SQL Server (LocalDB or SQL Server)
- Visual Studio 2022 or VS Code

## 🚀 Installation

> **💡 Learning Purpose**: This basic version is perfect for learning ASP.NET Core MVC fundamentals. For production use, consider the [StandBlog](https://github.com/dugerdev/StandBlog).

### 1. Clone the Project
```bash
git clone https://github.com/dugerdev/MvcStandBlog.git
cd MvcStandBlog
```

### 2. Install Dependencies
```bash
dotnet restore
```

### 3. Configure Database
Edit the connection string in `appsettings.json` according to your database settings:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StandBlogDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
  }
}
```

### 4. Create Database
```bash
dotnet ef database update
```

### 5. Run the Application
```bash
dotnet run
```

The application will run at `https://localhost:7063` or `http://localhost:5001`.

## 📁 Project Structure

```
MvcStandBlog/
├── Controllers/          # MVC Controllers
│   ├── HomeController.cs
│   ├── BlogController.cs
│   ├── AboutController.cs
│   ├── ContactController.cs
│   └── PostDetailsController.cs
├── Data/                 # Database context
│   └── StandBlogContext.cs
├── Models/               # Data models
│   └── Entities/
│       ├── BaseEntity.cs
│       ├── Blog.cs
│       ├── Category.cs
│       ├── Tag.cs
│       ├── BlogTag.cs
│       ├── Comment.cs
│       └── Contact.cs
├── Mappings/             # Entity Framework configurations
│   ├── BlogConfiguration.cs
│   ├── CategoryConfiguration.cs
│   ├── TagConfiguration.cs
│   ├── BlogTagConfiguration.cs
│   ├── CommentConfiguration.cs
│   └── ContactConfiguration.cs
├── Views/                # Razor views
│   ├── Home/
│   ├── Blog/
│   ├── About/
│   ├── Contact/
│   ├── PostDetails/
│   └── Shared/
├── wwwroot/              # Static files
│   ├── assets/
│   └── vendor/
└── Migrations/           # Database migrations
```

## 🗄️ Database Schema

### Tables
- **Blogs**: Blog posts
- **Categories**: Categories
- **Tags**: Tags
- **BlogTags**: Blog-Tag relationship (Many-to-Many)
- **Comments**: Comments
- **Contacts**: Contact messages

### Key Features
- All tables inherit from `BaseEntity` class
- Soft delete support (`IsDeleted` field)
- Automatic date records (`CreatedOn`, `UpdatedOn`, `DeletedOn`)
- Unique constraints and indexes

## 🔧 Development

### Creating New Migration
```bash
dotnet ef migrations add MigrationName
```

### Updating Database
```bash
dotnet ef database update
```

### Rolling Back Migration
```bash
dotnet ef database update PreviousMigrationName
```

## 📝 API Endpoints

| HTTP Method | Endpoint | Description |
|-------------|----------|-------------|
| GET | `/` | Home page |
| GET | `/Home/Index` | Home page |
| GET | `/Blog/Blog` | Blog list |
| GET | `/About/About` | About page |
| GET | `/Contact/Contact` | Contact page |
| POST | `/Contact/Contact` | Contact form submission |
| GET | `/PostDetails/PostDetails` | Blog detail page |

## 🎨 Customization

### Changing Theme
You can customize the theme by editing the CSS files in the `wwwroot/assets/css/` folder.

### Adding New Page
1. Add new controller to `Controllers/` folder
2. Add related views to `Views/` folder
3. Define necessary routes in `Program.cs` file

## 🐛 Bug Reports

If you find a bug, please report it via the [Issues](https://github.com/dugerdev/WA_MVC_StandBlog/issues) page.

## 🤝 Contributing

1. Fork this project
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Create a Pull Request

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## 👨‍💻 Developer

**Muhammed**
- GitHub: [@dugerdev](https://github.com/dugerdev)
- Email: muhammedduger@outlook.com

## 🔗 Related Projects

- **[StandBlog](https://github.com/dugerdev/StandBlog)** - Full-featured version with admin panel, user management, and advanced features
- **[Other Projects](https://github.com/dugerdev)** - Check out my other repositories

## 🙏 Acknowledgments

- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) - Web framework
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - ORM
- [Bootstrap](https://getbootstrap.com/) - CSS framework
- [jQuery](https://jquery.com/) - JavaScript library

---

⭐ If you liked this project, don't forget to give it a star!

> **🚀 Ready for more?** Check out the [StandBlog](https://github.com/dugerdev/StandBlog) for advanced features and production-ready code!