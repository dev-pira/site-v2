using Devpira.Infrastructure.Db;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Devpira.Migrations;

public class MigrationsContext(DbContextOptions options) : ApplicationContext(options);