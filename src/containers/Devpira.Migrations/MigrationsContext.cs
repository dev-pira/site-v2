using Devpira.Infrastructure.Db;

using Microsoft.EntityFrameworkCore;

namespace Devpira.Migrations;

public class MigrationsContext(DbContextOptions options) : ApplicationContext(options);