using Microsoft.EntityFrameworkCore;
using StaticaDbContext.Models;
using Task = StaticaDbContext.Models.Task;
using Version = StaticaDbContext.Models.Version;

namespace StaticaDbContext
{
    public partial class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly string _connectionString;

        public DbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public virtual DbSet<AdditDefaultValue> AdditDefaultValues { get; set; } = null!;
        public virtual DbSet<AdditFieldsCatalog> AdditFieldsCatalogs { get; set; } = null!;
        public virtual DbSet<AdditionalField> AdditionalFields { get; set; } = null!;
        public virtual DbSet<ApiSetting> ApiSettings { get; set; } = null!;
        public virtual DbSet<AutomaticDevice> AutomaticDevices { get; set; } = null!;
        public virtual DbSet<AutomaticDeviceStatus> AutomaticDeviceStatuses { get; set; } = null!;
        public virtual DbSet<Axle> Axles { get; set; } = null!;
        public virtual DbSet<BadTransaction> BadTransactions { get; set; } = null!;
        public virtual DbSet<Betw> Betws { get; set; } = null!;
        public virtual DbSet<BetwBru> BetwBrus { get; set; } = null!;
        public virtual DbSet<BetweenCar> BetweenCars { get; set; } = null!;
        public virtual DbSet<BetweenTrailer> BetweenTrailers { get; set; } = null!;
        public virtual DbSet<Cam> Cams { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<DefValsTemplate> DefValsTemplates { get; set; } = null!;
        public virtual DbSet<DefaultValue> DefaultValues { get; set; } = null!;
        public virtual DbSet<DigitTable> DigitTables { get; set; } = null!;
        public virtual DbSet<DigitTableStatus> DigitTableStatuses { get; set; } = null!;
        public virtual DbSet<DigitTableText> DigitTableTexts { get; set; } = null!;
        public virtual DbSet<DownSuspCar> DownSuspCars { get; set; } = null!;
        public virtual DbSet<DownSuspTrailer> DownSuspTrailers { get; set; } = null!;
        public virtual DbSet<Downsusp> Downsusps { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<Gate> Gates { get; set; } = null!;
        public virtual DbSet<Good> Goods { get; set; } = null!;
        public virtual DbSet<Journal> Journals { get; set; } = null!;
        public virtual DbSet<JournalApiSend> JournalApiSends { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LukoilTable> LukoilTables { get; set; } = null!;
        public virtual DbSet<LukoilTableMethodNew> LukoilTableMethodNews { get; set; } = null!;
        public virtual DbSet<LukoilTableRecount> LukoilTableRecounts { get; set; } = null!;
        public virtual DbSet<MobUser> MobUsers { get; set; } = null!;
        public virtual DbSet<OnlineAdditional> OnlineAdditionals { get; set; } = null!;
        public virtual DbSet<ParamsCom> ParamsComs { get; set; } = null!;
        public virtual DbSet<ParamsComView> ParamsComViews { get; set; } = null!;
        public virtual DbSet<ParamsIp> ParamsIps { get; set; } = null!;
        public virtual DbSet<ParamsIpView> ParamsIpViews { get; set; } = null!;
        public virtual DbSet<PepsiRecord> PepsiRecords { get; set; } = null!;
        public virtual DbSet<Picture> Pictures { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PostsAndUser> PostsAndUsers { get; set; } = null!;
        public virtual DbSet<PrintScheme> PrintSchemes { get; set; } = null!;
        public virtual DbSet<Qr> Qrs { get; set; } = null!;
        public virtual DbSet<QrJournal> QrJournals { get; set; } = null!;
        public virtual DbSet<RecAlias> RecAliases { get; set; } = null!;
        public virtual DbSet<RecKpp> RecKpps { get; set; } = null!;
        public virtual DbSet<RecSetting> RecSettings { get; set; } = null!;
        public virtual DbSet<Reserved> Reserveds { get; set; } = null!;
        public virtual DbSet<Rfid> Rfids { get; set; } = null!;
        public virtual DbSet<Scale> Scales { get; set; } = null!;
        public virtual DbSet<Sensor> Sensors { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<Station> Stations { get; set; } = null!;
        public virtual DbSet<Tare> Tares { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<TasksAndDriver> TasksAndDrivers { get; set; } = null!;
        public virtual DbSet<TisTable> TisTables { get; set; } = null!;
        public virtual DbSet<TrafficLight> TrafficLights { get; set; } = null!;
        public virtual DbSet<Trailer> Trailers { get; set; } = null!;
        public virtual DbSet<Train> Trains { get; set; } = null!;
        public virtual DbSet<TroikaTable> TroikaTables { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vel> Vels { get; set; } = null!;
        public virtual DbSet<Version> Versions { get; set; } = null!;
        public virtual DbSet<WebUser> WebUsers { get; set; } = null!;
        public virtual DbSet<WeighTime> WeighTimes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum("action_type_enum", new[] { "Вход", "Выход", "Взвешивание", "Удаление", "Изменение", "Нажатие клавиши" })
                .HasPostgresEnum("additional_field_type_enum", new[] { "Поле", "Перечисление" })
                .HasPostgresEnum("aligns_enum", new[] { "Слева", "По центру", "Справа" })
                .HasPostgresEnum("baud_rate_enum", new[] { "9600", "14400", "19200", "38400", "57600", "115200" })
                .HasPostgresEnum("cam_mode_view", new[] { "RTSP", "MJPEG" })
                .HasPostgresEnum("coord_type_enum", new[] { "Xn >>> Xm", "-Xm <<< Xn", "Yn >>> -Ym" })
                .HasPostgresEnum("digit_table_type", new[] { "COM", "IP" })
                .HasPostgresEnum("dimension_type_enum", new[] { ">>>", "<<<" })
                .HasPostgresEnum("measure_enum", new[] { "г", "кг", "т" })
                .HasPostgresEnum("protocol_enum", new[] { "Тензо-М", "6.43", "Metra (ASCII)", "Metrabus (CRC)", "Metrabus (CRC8)", "TM2020", "CAS", "ФизТех" })
                .HasPostgresEnum("role_enum", new[] { "Администратор", "Пользователь" })
                .HasPostgresEnum("scales_essense_enum", new[] { "ВА", "ВА-Д", "АВИОН" })
                .HasPostgresEnum("scales_type_enum", new[] { "Автомобильные", "Платформенные", "Вагонные", "Мобильные" })
                .HasPostgresEnum("status_enum", new[] { "Ожидание груза", "Взвешивание", "Освобождение весов", "Пользовательский 1", "Пользовательский 2", "Заезд", "Съезд", "Движение запрещено", "Проехать прямо", "Сдать назад", "КПП", "Некорректное взвешивание", "Корректное взвешивание", "Ожидание груза (реверс)", "Заезд (реверс)", "Освобождение весов (реверс)", "Сбой", "Сбой (груз)", "Некорректное взвешивание (реверс)", "Корректное взвешивание (реверс)", "Стоп" })
                .HasPostgresEnum("weight_type_enum", new[] { "Тара >> Брутто", "Брутто >> Тара", "Тара | Брутто", "Только брутто" })
                .HasPostgresEnum("weighting_enum", new[] { "ТАРА", "БРУТТО" })
                .HasPostgresEnum("work_type_enum", new[] { "Ручной", "Автоматический" })
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("uuid_oosp", "uuid-ossp");

            modelBuilder.Entity<AdditDefaultValue>(entity =>
            {
                entity.ToTable("addit_default_values");

                entity.HasIndex(e => e.AdditFieldCatId, "addit_default_values_addit_field_cat_id_idx");

                entity.HasIndex(e => e.AdditFieldId, "addit_default_values_addit_field_id_idx");

                entity.HasIndex(e => e.TemplateId, "addit_default_values_template_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('addit_def_vals_id_seq'::regclass)");

                entity.Property(e => e.AdditFieldCatId).HasColumnName("addit_field_cat_id");

                entity.Property(e => e.AdditFieldId).HasColumnName("addit_field_id");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .HasColumnName("value");

                entity.HasOne(d => d.AdditFieldCat)
                    .WithMany(p => p.AdditDefaultValues)
                    .HasForeignKey(d => d.AdditFieldCatId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("addit_default_values_addit_field_cat_id_fkey");

                entity.HasOne(d => d.AdditField)
                    .WithMany(p => p.AdditDefaultValues)
                    .HasForeignKey(d => d.AdditFieldId)
                    .HasConstraintName("addit_default_values_addit_field_id_fkey");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.AdditDefaultValues)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("addit_default_values_template_id_fkey");
            });

            modelBuilder.Entity<AdditFieldsCatalog>(entity =>
            {
                entity.ToTable("addit_fields_catalog");

                entity.HasIndex(e => e.AdditFieldId, "addit_fields_catalog_addit_field_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('addit_field_catalog_id_seq'::regclass)");

                entity.Property(e => e.AdditFieldId).HasColumnName("addit_field_id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.HasOne(d => d.AdditField)
                    .WithMany(p => p.AdditFieldsCatalogs)
                    .HasForeignKey(d => d.AdditFieldId)
                    .HasConstraintName("addit_field_cat_to_additfield_foreign_key");
            });

            modelBuilder.Entity<AdditionalField>(entity =>
            {
                entity.ToTable("additional_fields");

                entity.HasIndex(e => e.ColName, "additional_fields_col_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('additional_field_id_seq'::regclass)");

                entity.Property(e => e.ColName)
                    .HasMaxLength(128)
                    .HasColumnName("col_name");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.TvInput)
                    .HasColumnName("tv_input")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<ApiSetting>(entity =>
            {
                entity.ToTable("api_settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiAuthCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_auth_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiAutosend).HasColumnName("api_autosend");

                entity.Property(e => e.ApiHost)
                    .HasMaxLength(128)
                    .HasColumnName("api_host")
                    .HasDefaultValueSql("'localhost'::character varying");

                entity.Property(e => e.ApiLogin)
                    .HasMaxLength(128)
                    .HasColumnName("api_login")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiPassword)
                    .HasMaxLength(128)
                    .HasColumnName("api_password")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiPort)
                    .HasColumnName("api_port")
                    .HasDefaultValueSql("80");

                entity.Property(e => e.ApiSendAllWeights).HasColumnName("api_send_all_weights");

                entity.Property(e => e.ApiSendPhotos)
                    .IsRequired()
                    .HasColumnName("api_send_photos")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ApiSendWCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_send_w_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiSsl).HasColumnName("api_ssl");

                entity.Property(e => e.ApiSyncCarCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_sync_car_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiSyncCompCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_sync_comp_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiSyncDriverCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_sync_driver_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiSyncGoodCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_sync_good_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiSyncTrailerCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_sync_trailer_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiSyncTrainCmd)
                    .HasMaxLength(128)
                    .HasColumnName("api_sync_train_cmd")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ApiUseAuth).HasColumnName("api_use_auth");

                entity.Property(e => e.ApiUseSendW).HasColumnName("api_use_send_w");

                entity.Property(e => e.ApiUseToken).HasColumnName("api_use_token");

                entity.Property(e => e.RetryTime)
                    .HasColumnName("retry_time")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.UseRetrySendWeights).HasColumnName("use_retry_send_weights");
            });

            modelBuilder.Entity<AutomaticDevice>(entity =>
            {
                entity.ToTable("automatic_devices");

                entity.HasIndex(e => e.PostId, "automatic_devices_post_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('automatic_device_id_seq'::regclass)");

                entity.Property(e => e.Address)
                    .HasMaxLength(128)
                    .HasColumnName("address");

                entity.Property(e => e.CheckIfGatesOpen).HasColumnName("check_if_gates_open");

                entity.Property(e => e.ConTimeout)
                    .HasColumnName("con_timeout")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.IpParamsId).HasColumnName("ip_params_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasDefaultValueSql("502");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Retries)
                    .HasColumnName("retries")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.ServerNum)
                    .HasColumnName("server_num")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.IpParams)
                    .WithMany(p => p.AutomaticDevices)
                    .HasForeignKey(d => d.IpParamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("automatic_devices_ip_params_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.AutomaticDevices)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("post_autodevice_fk_id");
            });

            modelBuilder.Entity<AutomaticDeviceStatus>(entity =>
            {
                entity.ToTable("automatic_device_statuses");

                entity.HasIndex(e => e.GatesId, "automatic_device_statuses_gates_id_idx");

                entity.HasIndex(e => e.PostId, "automatic_device_statuses_post_id_idx");

                entity.HasIndex(e => e.TrafficLightId, "automatic_device_statuses_traffic_light_id_idx");

                entity.HasIndex(e => e.AutodeviceId, "fki_auto_device_statuses_auto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('status_autodevice_id_seq'::regclass)");

                entity.Property(e => e.AutodeviceId).HasColumnName("autodevice_id");

                entity.Property(e => e.GatesId).HasColumnName("gates_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.TrafficLightId).HasColumnName("traffic_light_id");

                entity.HasOne(d => d.Autodevice)
                    .WithMany(p => p.AutomaticDeviceStatuses)
                    .HasForeignKey(d => d.AutodeviceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auto_device_statuses_auto_id");

                entity.HasOne(d => d.Gates)
                    .WithMany(p => p.AutomaticDeviceStatuses)
                    .HasForeignKey(d => d.GatesId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("gates_id_fk");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.AutomaticDeviceStatuses)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("post_id_auto_id_fk_id");

                entity.HasOne(d => d.TrafficLight)
                    .WithMany(p => p.AutomaticDeviceStatuses)
                    .HasForeignKey(d => d.TrafficLightId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("traffic_light_fk_id");
            });

            modelBuilder.Entity<Axle>(entity =>
            {
                entity.ToTable("axles");

                entity.HasIndex(e => e.JournalId, "axles_journal_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BruttoWeight).HasColumnName("brutto_weight");

                entity.Property(e => e.IsOverweightBrutto)
                    .HasColumnName("is_overweight_brutto")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.TareWeight).HasColumnName("tare_weight");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Axles)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("axles_journal_id_fkey");
            });

            modelBuilder.Entity<BadTransaction>(entity =>
            {
                entity.ToTable("bad_transactions", "addons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Photo1).HasColumnName("photo1");

                entity.Property(e => e.Photo2).HasColumnName("photo2");

                entity.Property(e => e.Photo3).HasColumnName("photo3");

                entity.Property(e => e.Photo4).HasColumnName("photo4");

                entity.Property(e => e.Plate)
                    .HasMaxLength(64)
                    .HasColumnName("plate");

                entity.Property(e => e.Rfid)
                    .HasMaxLength(64)
                    .HasColumnName("rfid");

                entity.Property(e => e.RfidId)
                    .HasMaxLength(64)
                    .HasColumnName("rfid_id");

                entity.Property(e => e.WeighDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("weigh_date");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Betw>(entity =>
            {
                entity.ToTable("betw");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('between_id_seq'::regclass)");

                entity.Property(e => e.BetVal).HasColumnName("bet_val");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Betws)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("between_journal_id_fkey");
            });

            modelBuilder.Entity<BetwBru>(entity =>
            {
                entity.ToTable("betw_bru");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('between_bru_id_seq'::regclass)");

                entity.Property(e => e.BetVal).HasColumnName("bet_val");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.BetwBrus)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("between_journal_id_fkey_2");
            });

            modelBuilder.Entity<BetweenCar>(entity =>
            {
                entity.ToTable("between_cars");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Betw).HasColumnName("betw");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.BetweenCars)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("between_cars_id_fkey");
            });

            modelBuilder.Entity<BetweenTrailer>(entity =>
            {
                entity.ToTable("between_trailers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Betw).HasColumnName("betw");

                entity.Property(e => e.TrailerId).HasColumnName("trailer_id");

                entity.HasOne(d => d.Trailer)
                    .WithMany(p => p.BetweenTrailers)
                    .HasForeignKey(d => d.TrailerId)
                    .HasConstraintName("between_trailers_id_fkey");
            });

            modelBuilder.Entity<Cam>(entity =>
            {
                entity.ToTable("cams");

                entity.HasComment("IP-камеры");

                entity.HasIndex(e => e.PostId, "cams_post_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CamName)
                    .HasMaxLength(80)
                    .HasColumnName("cam_name")
                    .HasDefaultValueSql("'Имя камеры'::character varying");

                entity.Property(e => e.CamRate)
                    .HasColumnName("cam_rate")
                    .HasDefaultValueSql("200");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasDefaultValueSql("'192.168.0.99'::inet");

                entity.Property(e => e.IpParamsId).HasColumnName("ip_params_id");

                entity.Property(e => e.IsOverview)
                    .HasColumnName("is_overview")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IsReverse)
                    .HasColumnName("is_reverse")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Login)
                    .HasMaxLength(128)
                    .HasColumnName("login")
                    .HasDefaultValueSql("'login'::character varying");

                entity.Property(e => e.OnlySnapshots)
                    .HasColumnName("only_snapshots")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Pass)
                    .HasMaxLength(128)
                    .HasColumnName("pass")
                    .HasDefaultValueSql("'password'::character varying");

                entity.Property(e => e.Path)
                    .HasMaxLength(1024)
                    .HasColumnName("path")
                    .HasDefaultValueSql("'/h264'::character varying");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasDefaultValueSql("554");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.ReadOnly).HasColumnName("read_only");

                entity.Property(e => e.UseInKpp)
                    .HasColumnName("use_in_kpp")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseMainThreadMjpeg)
                    .HasColumnName("use_main_thread_mjpeg")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ViaHttp)
                    .HasColumnName("via_http")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.IpParams)
                    .WithMany(p => p.Cams)
                    .HasForeignKey(d => d.IpParamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cams_ip_params_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Cams)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cams_post_id");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("cars");

                entity.HasComment("Автомобили");

                entity.HasIndex(e => e.ParentId, "cars_parent_id_idx");

                entity.HasIndex(e => e.SenderId, "fki_cars_companies");

                entity.HasIndex(e => e.RecipientId, "fki_cars_companies_r");

                entity.HasIndex(e => e.TransitId, "fki_cars_companies_tr");

                entity.HasIndex(e => e.GoodId, "fki_cars_goods");

                entity.HasIndex(e => e.TrailerId, "fki_cars_trailers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Driver).HasColumnName("driver");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.Isgroup)
                    .IsRequired()
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Mark)
                    .HasMaxLength(64)
                    .HasColumnName("mark");

                entity.Property(e => e.Model)
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("add_item('ТС '::character varying, 'cars'::character varying)");

                entity.Property(e => e.NoPrint)
                    .HasColumnName("no_print")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("currval('cars_id_seq'::regclass)");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.RfidCode)
                    .HasMaxLength(128)
                    .HasColumnName("rfid_code");

                entity.Property(e => e.SenderId).HasColumnName("sender_id");

                entity.Property(e => e.Tara).HasColumnName("tara");

                entity.Property(e => e.TrailerId).HasColumnName("trailer_id");

                entity.Property(e => e.TransitId).HasColumnName("transit_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(64)
                    .HasColumnName("type");

                entity.HasOne(d => d.DriverNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.Driver)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_cars_drivers");

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.GoodId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_cars_goods");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_cars_cars");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.CarRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_cars_companies_r");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.CarSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_cars_companies");

                entity.HasOne(d => d.Trailer)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.TrailerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_cars_trailers");

                entity.HasOne(d => d.Transit)
                    .WithMany(p => p.CarTransits)
                    .HasForeignKey(d => d.TransitId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_cars_companies_tr");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("companies");

                entity.HasComment("Контрагенты");

                entity.HasIndex(e => e.ParentId, "companies_parent_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contacts)
                    .HasMaxLength(128)
                    .HasColumnName("contacts");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FactAddress)
                    .HasMaxLength(1024)
                    .HasColumnName("fact_address");

                entity.Property(e => e.Inn)
                    .HasMaxLength(64)
                    .HasColumnName("inn");

                entity.Property(e => e.Isgroup)
                    .IsRequired()
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(64)
                    .HasColumnName("kpp");

                entity.Property(e => e.LawAddress)
                    .HasMaxLength(1024)
                    .HasColumnName("law_address");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasDefaultValueSql("add_item('Контрагент '::character varying, 'companies'::character varying)");

                entity.Property(e => e.NoPrint)
                    .HasColumnName("no_print")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Ogrn)
                    .HasMaxLength(64)
                    .HasColumnName("ogrn");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("currval('companies_id_seq'::regclass)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_companies_companies");
            });

            modelBuilder.Entity<DefValsTemplate>(entity =>
            {
                entity.ToTable("def_vals_templates");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('def_vals_temp_seq_id'::regclass)");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DefaultValue>(entity =>
            {
                entity.ToTable("default_values");

                entity.HasIndex(e => e.GoodId, "default_values_good_id_idx");

                entity.HasIndex(e => e.PayerId, "default_values_payer_id_idx");

                entity.HasIndex(e => e.RecipientId, "default_values_recipient_id_idx");

                entity.HasIndex(e => e.SenderId, "default_values_sender_id_idx");

                entity.HasIndex(e => e.TemplateId, "default_values_template_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('default_vals_id_seq'::regclass)");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.PayerId).HasColumnName("payer_id");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.SenderId).HasColumnName("sender_id");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.TransitId).HasColumnName("transit_id");

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.DefaultValues)
                    .HasForeignKey(d => d.GoodId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("default_values_good_id_fkey");

                entity.HasOne(d => d.Payer)
                    .WithMany(p => p.DefaultValuePayers)
                    .HasForeignKey(d => d.PayerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("default_values_payer_id_fkey");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.DefaultValueRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("default_values_recipient_id_fkey");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.DefaultValueSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("default_values_sender_id_fkey");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.DefaultValues)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("default_values_template_id_fkey");

                entity.HasOne(d => d.Transit)
                    .WithMany(p => p.DefaultValueTransits)
                    .HasForeignKey(d => d.TransitId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("default_values_transit_id_fkey");
            });

            modelBuilder.Entity<DigitTable>(entity =>
            {
                entity.ToTable("digit_tables");

                entity.HasIndex(e => e.ComParamsId, "digit_tables_com_params_id_idx");

                entity.HasIndex(e => e.PostId, "fki_dt_post_id_ref_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('digit_table_id_seq'::regclass)");

                entity.Property(e => e.Address)
                    .HasMaxLength(128)
                    .HasColumnName("address");

                entity.Property(e => e.Brightness)
                    .HasColumnName("brightness")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.ComParamsId).HasColumnName("com_params_id");

                entity.Property(e => e.Dttype)
                    .HasColumnName("dttype")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IpParamsId).HasColumnName("ip_params_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasDefaultValueSql("4001");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.TranslatePsResult).HasColumnName("translate_ps_result");

                entity.Property(e => e.TranslateWeight)
                    .HasColumnName("translate_weight")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.ComParams)
                    .WithMany(p => p.DigitTables)
                    .HasForeignKey(d => d.ComParamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("digit_tables_com_params_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.DigitTables)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("dt_post_id_ref_id");
            });

            modelBuilder.Entity<DigitTableStatus>(entity =>
            {
                entity.ToTable("digit_table_statuses");

                entity.HasIndex(e => e.PostId, "digit_table_statuses_post_id_idx");

                entity.HasIndex(e => e.TextStatusId, "digit_table_statuses_text_status_id_idx");

                entity.HasIndex(e => e.DigitTableId, "fki_digit_table_statuses_dt_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('status_digit_table_id_seq'::regclass)");

                entity.Property(e => e.DigitTableId).HasColumnName("digit_table_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.TextStatusId).HasColumnName("text_status_id");

                entity.HasOne(d => d.DigitTable)
                    .WithMany(p => p.DigitTableStatuses)
                    .HasForeignKey(d => d.DigitTableId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("digit_table_statuses_dt_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.DigitTableStatuses)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("digit_table_statuses_post_id_fk");

                entity.HasOne(d => d.TextStatus)
                    .WithMany(p => p.DigitTableStatuses)
                    .HasForeignKey(d => d.TextStatusId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("digit_table_statuses_text_fk");
            });

            modelBuilder.Entity<DigitTableText>(entity =>
            {
                entity.ToTable("digit_table_text");

                entity.HasIndex(e => e.DigitTableId, "digit_table_text_digit_table_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DigitTableId).HasColumnName("digit_table_id");

                entity.Property(e => e.IsDouble).HasColumnName("is_double");

                entity.Property(e => e.IsRound).HasColumnName("is_round");

                entity.Property(e => e.IsWeiSend).HasColumnName("is_wei_send");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Text1)
                    .HasMaxLength(128)
                    .HasColumnName("text1");

                entity.Property(e => e.Text2)
                    .HasMaxLength(128)
                    .HasColumnName("text2");

                entity.HasOne(d => d.DigitTable)
                    .WithMany(p => p.DigitTableTexts)
                    .HasForeignKey(d => d.DigitTableId)
                    .HasConstraintName("digit_table_fk_id");
            });

            modelBuilder.Entity<DownSuspCar>(entity =>
            {
                entity.ToTable("down_susp_cars");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.Down).HasColumnName("down");

                entity.Property(e => e.Susp).HasColumnName("susp");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.DownSuspCars)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("down_susp_cars_id_fkey");
            });

            modelBuilder.Entity<DownSuspTrailer>(entity =>
            {
                entity.ToTable("down_susp_trailers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Down).HasColumnName("down");

                entity.Property(e => e.Susp).HasColumnName("susp");

                entity.Property(e => e.TrailerId).HasColumnName("trailer_id");

                entity.HasOne(d => d.Trailer)
                    .WithMany(p => p.DownSuspTrailers)
                    .HasForeignKey(d => d.TrailerId)
                    .HasConstraintName("down_susp_trailers_id_fkey");
            });

            modelBuilder.Entity<Downsusp>(entity =>
            {
                entity.ToTable("downsusp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Down).HasColumnName("down");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Susp).HasColumnName("susp");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Downsusps)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("downsusp_journal_id_fkey");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("drivers");

                entity.HasComment("Водители");

                entity.HasIndex(e => e.ParentId, "drivers_parent_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(64)
                    .HasColumnName("comment");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Document)
                    .HasMaxLength(128)
                    .HasColumnName("document");

                entity.Property(e => e.Isgroup)
                    .IsRequired()
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("add_item('Водитель '::character varying, 'drivers'::character varying)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("currval('drivers_id_seq'::regclass)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_drivers_drivers");
            });

            modelBuilder.Entity<Gate>(entity =>
            {
                entity.ToTable("gates");

                entity.HasIndex(e => e.AutodeviceId, "gates_autodevice_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutodeviceId).HasColumnName("autodevice_id");

                entity.Property(e => e.ContactNum).HasColumnName("contact_num");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.OpenControlContact)
                    .HasColumnName("open_control_contact")
                    .HasDefaultValueSql("(-1)");

                entity.Property(e => e.ToUp).HasColumnName("to_up");

                entity.HasOne(d => d.Autodevice)
                    .WithMany(p => p.Gates)
                    .HasForeignKey(d => d.AutodeviceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("gates_autodevice_fk_id");
            });

            modelBuilder.Entity<Good>(entity =>
            {
                entity.ToTable("goods");

                entity.HasComment("Номенклатура");

                entity.HasIndex(e => e.ParentId, "goods_parent_id_idx");

                entity.HasIndex(e => e.TareId, "goods_tare_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(256)
                    .HasColumnName("barcode");

                entity.Property(e => e.Coef)
                    .HasColumnName("coef")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CoefAction)
                    .HasColumnName("coef_action")
                    .HasDefaultValueSql("0")
                    .HasComment("0 - multiply, 1 - plus, 2 - minus, 3 - divide");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IconName)
                    .HasMaxLength(64)
                    .HasColumnName("icon_name");

                entity.Property(e => e.Isgroup)
                    .IsRequired()
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MeasureCoef)
                    .HasMaxLength(32)
                    .HasColumnName("measure_coef");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("add_item('Груз '::character varying, 'goods'::character varying)");

                entity.Property(e => e.NoPrint)
                    .HasColumnName("no_print")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("currval('goods_id_seq'::regclass)");

                entity.Property(e => e.TareId).HasColumnName("tare_id");

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(128)
                    .HasColumnName("vendor_code");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_goods_goods");

                entity.HasOne(d => d.Tare)
                    .WithMany(p => p.Goods)
                    .HasForeignKey(d => d.TareId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_goods_tares");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.ToTable("journal");

                entity.HasIndex(e => e.UserId, "fki_user_id_foreign_key");

                entity.HasIndex(e => e.BadTransit, "journal_bad_transit_idx");

                entity.HasIndex(e => e.CarId, "journal_car_id_idx");

                entity.HasIndex(e => e.CompanyPayer, "journal_company_payer_idx");

                entity.HasIndex(e => e.CompanyRecipient, "journal_company_recipient_idx");

                entity.HasIndex(e => e.CompanySender, "journal_company_sender_idx");

                entity.HasIndex(e => e.CompanyTransit, "journal_company_transit_idx");

                entity.HasIndex(e => e.CreationDate, "journal_creation_date_idx");

                entity.HasIndex(e => e.Deleted, "journal_deleted_idx");

                entity.HasIndex(e => e.DriverId, "journal_driver_id_idx");

                entity.HasIndex(e => e.GoodId, "journal_good_id_idx");

                entity.HasIndex(e => e.PostName, "journal_post_name_idx")
                    .HasOperators(new[] { "text_pattern_ops" });

                entity.HasIndex(e => e.TrailerId, "journal_trailer_id_idx");

                entity.HasIndex(e => e.TrainId, "journal_train_id_idx");

                entity.HasIndex(e => e.UserId, "journal_user_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BadTransit).HasColumnName("bad_transit");

                entity.Property(e => e.Blocked).HasColumnName("blocked");

                entity.Property(e => e.Brutto).HasColumnName("brutto");

                entity.Property(e => e.BruttoDate).HasColumnName("brutto_date");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CoefWeight).HasColumnName("coef_weight");

                entity.Property(e => e.CompanyPayer).HasColumnName("company_payer");

                entity.Property(e => e.CompanyRecipient).HasColumnName("company_recipient");

                entity.Property(e => e.CompanySender).HasColumnName("company_sender");

                entity.Property(e => e.CompanyTransit).HasColumnName("company_transit");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.Property(e => e.Finished).HasColumnName("finished");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.MoveDirection).HasColumnName("move_direction");

                entity.Property(e => e.MsScalesName)
                    .HasMaxLength(64)
                    .HasColumnName("ms_scales_name");

                entity.Property(e => e.MsWgroupName)
                    .HasMaxLength(64)
                    .HasColumnName("ms_wgroup_name");

                entity.Property(e => e.Netto).HasColumnName("netto");

                entity.Property(e => e.NettoDate).HasColumnName("netto_date");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PostName)
                    .HasMaxLength(64)
                    .HasColumnName("post_name");

                entity.Property(e => e.RfidCode).HasColumnName("rfid_code");

                entity.Property(e => e.Tare).HasColumnName("tare");

                entity.Property(e => e.TareDate).HasColumnName("tare_date");

                entity.Property(e => e.TrailerId).HasColumnName("trailer_id");

                entity.Property(e => e.TrainId).HasColumnName("train_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("carid_foreign_key");

                entity.HasOne(d => d.CompanyPayerNavigation)
                    .WithMany(p => p.JournalCompanyPayerNavigations)
                    .HasForeignKey(d => d.CompanyPayer)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("c_payer_fk");

                entity.HasOne(d => d.CompanyRecipientNavigation)
                    .WithMany(p => p.JournalCompanyRecipientNavigations)
                    .HasForeignKey(d => d.CompanyRecipient)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("c_recipient_fk");

                entity.HasOne(d => d.CompanySenderNavigation)
                    .WithMany(p => p.JournalCompanySenderNavigations)
                    .HasForeignKey(d => d.CompanySender)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("c_sender_fk");

                entity.HasOne(d => d.CompanyTransitNavigation)
                    .WithMany(p => p.JournalCompanyTransitNavigations)
                    .HasForeignKey(d => d.CompanyTransit)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("c_transit_fk");

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.GoodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("goodid_foreign_key");

                entity.HasOne(d => d.Trailer)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.TrailerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("trailerid_foreign_key");

                entity.HasOne(d => d.Train)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.TrainId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("trainid_foreign_key");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("user_id_foreign_key");
            });

            modelBuilder.Entity<JournalApiSend>(entity =>
            {
                entity.ToTable("journal_api_send");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.JournalApiSends)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("journal_api_send_journal_id_fkey");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("logs");

                entity.HasIndex(e => e.ActionDate, "logs_action_date_idx");

                entity.HasIndex(e => e.UserId, "logs_user_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionDate)
                    .HasColumnName("action_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ActionThing)
                    .HasMaxLength(128)
                    .HasColumnName("action_thing");

                entity.Property(e => e.OldValue)
                    .HasMaxLength(128)
                    .HasColumnName("old_value");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .HasColumnName("value");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("logs_user_id_fkey");
            });

            modelBuilder.Entity<LukoilTable>(entity =>
            {
                entity.ToTable("lukoil_table", "addons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brutto).HasColumnName("brutto");

                entity.Property(e => e.GosNum)
                    .HasMaxLength(64)
                    .HasColumnName("gos_num");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Netto).HasColumnName("netto");

                entity.Property(e => e.Oiled).HasColumnName("oiled");

                entity.Property(e => e.Tare).HasColumnName("tare");

                entity.Property(e => e.WeightDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("weight_date");
            });

            modelBuilder.Entity<LukoilTableMethodNew>(entity =>
            {
                entity.ToTable("lukoil_table_method_new", "addons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brutto).HasColumnName("brutto");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Netto).HasColumnName("netto");

                entity.Property(e => e.Oiled).HasColumnName("oiled");

                entity.Property(e => e.ScalesId)
                    .HasMaxLength(64)
                    .HasColumnName("scales_id");

                entity.Property(e => e.Tare).HasColumnName("tare");

                entity.Property(e => e.TicketId)
                    .HasMaxLength(64)
                    .HasColumnName("ticket_id");

                entity.Property(e => e.TrailerNum)
                    .HasMaxLength(64)
                    .HasColumnName("trailer_num");

                entity.Property(e => e.TrailerNumSuo)
                    .HasMaxLength(64)
                    .HasColumnName("trailer_num_suo");

                entity.Property(e => e.TruckNum)
                    .HasMaxLength(64)
                    .HasColumnName("truck_num");

                entity.Property(e => e.TruckNumSuo)
                    .HasMaxLength(64)
                    .HasColumnName("truck_num_suo");

                entity.Property(e => e.WasReverse).HasColumnName("was_reverse");

                entity.Property(e => e.WeightDate).HasColumnName("weight_date");
            });

            modelBuilder.Entity<LukoilTableRecount>(entity =>
            {
                entity.ToTable("lukoil_table_recount", "addons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.Good)
                    .HasMaxLength(1024)
                    .HasColumnName("good")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Press).HasColumnName("press");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.LukoilTableRecounts)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("lukoil_t_r_journal_fk_id_fkey");
            });

            modelBuilder.Entity<MobUser>(entity =>
            {
                entity.ToTable("mob_users");

                entity.HasIndex(e => e.Id, "mob_users_id_idx");

                entity.HasIndex(e => e.SystemLogin, "mob_users_system_login_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Login)
                    .HasMaxLength(128)
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .HasMaxLength(512)
                    .HasColumnName("password");

                entity.Property(e => e.SystemLogin).HasColumnName("system_login");

                entity.HasOne(d => d.SystemLoginNavigation)
                    .WithMany(p => p.MobUsers)
                    .HasForeignKey(d => d.SystemLogin)
                    .HasConstraintName("mob_users_system_login_fkey");
            });

            modelBuilder.Entity<OnlineAdditional>(entity =>
            {
                entity.ToTable("online_additional");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(64)
                    .HasColumnName("post_name");

                entity.Property(e => e.SumWeights).HasColumnName("sum_weights");
            });

            modelBuilder.Entity<ParamsCom>(entity =>
            {
                entity.ToTable("params_com");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Callback)
                    .HasColumnName("callback")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.ComPort)
                    .HasColumnType("character varying")
                    .HasColumnName("com_port")
                    .HasDefaultValueSql("'COM1'::character varying");
            });

            modelBuilder.Entity<ParamsComView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("params_com_view");

                entity.Property(e => e.Com).HasColumnName("com");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ParamsIp>(entity =>
            {
                entity.ToTable("params_ip");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Callback)
                    .HasColumnName("callback")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.HostName)
                    .HasMaxLength(128)
                    .HasColumnName("host_name")
                    .HasDefaultValueSql("'localhost'::character varying");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasDefaultValueSql("80");
            });

            modelBuilder.Entity<ParamsIpView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("params_ip_view");

                entity.Property(e => e.Host).HasColumnName("host");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<PepsiRecord>(entity =>
            {
                entity.ToTable("pepsi_records", "addons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.QrResult).HasColumnName("qr_result");

                entity.Property(e => e.TrResult).HasColumnName("tr_result");

                entity.Property(e => e.TrackNum)
                    .HasMaxLength(256)
                    .HasColumnName("track_num");

                entity.Property(e => e.TruckNum)
                    .HasMaxLength(64)
                    .HasColumnName("truck_num");

                entity.Property(e => e.WeightStatus).HasColumnName("weight_status");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.PepsiRecords)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pepsi_journal_fk_id_fkey");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("pictures");

                entity.HasIndex(e => e.JournalId, "pictures_journal_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Pictures)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("pic_journal_foreign_key");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("posts");

                entity.HasIndex(e => e.ConnectedPost, "posts_connected_post_idx");

                entity.HasIndex(e => e.ConnectedPost, "posts_connected_post_key")
                    .IsUnique();

                entity.HasIndex(e => e.SensorAutodeviceId, "posts_sensor_autodevice_id_idx");

                entity.HasIndex(e => e.SensorKppAutodeviceId, "posts_sensor_kpp_autodevice_id_idx");

                entity.HasIndex(e => e.TemplateId, "posts_template_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowAnyAxlesResults).HasColumnName("allow_any_axles_results");

                entity.Property(e => e.AskGood)
                    .HasColumnName("ask_good")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AskTare)
                    .HasColumnName("ask_tare")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CompareKppCamNumsWithCatalogs).HasColumnName("compare_kpp_cam_nums_with_catalogs");

                entity.Property(e => e.ConnectedPost).HasColumnName("connected_post");

                entity.Property(e => e.DivideRfid).HasColumnName("divide_rfid");

                entity.Property(e => e.HttpServerPort)
                    .HasColumnName("http_server_port")
                    .HasDefaultValueSql("9382");

                entity.Property(e => e.IgnoreDirection)
                    .HasColumnName("ignore_direction")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.KppCams).HasColumnName("kpp_cams");

                entity.Property(e => e.KppCamsWaitSec)
                    .HasColumnName("kpp_cams_wait_sec")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.MsServerPort)
                    .HasColumnName("ms_server_port")
                    .HasDefaultValueSql("9381");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'Наименование поста'::character varying");

                entity.Property(e => e.OnlyFindGood).HasColumnName("only_find_good");

                entity.Property(e => e.PrinterPath)
                    .HasMaxLength(256)
                    .HasColumnName("printer_path")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.QrBackId).HasColumnName("qr_back_id");

                entity.Property(e => e.QrId).HasColumnName("qr_id");

                entity.Property(e => e.RfidBackId).HasColumnName("rfid_back_id");

                entity.Property(e => e.RfidId).HasColumnName("rfid_id");

                entity.Property(e => e.SensorAutodeviceId).HasColumnName("sensor_autodevice_id");

                entity.Property(e => e.SensorKppAutodeviceId).HasColumnName("sensor_kpp_autodevice_id");

                entity.Property(e => e.ShowPhotoWidget)
                    .IsRequired()
                    .HasColumnName("show_photo_widget")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.UseAutodevices)
                    .HasColumnName("use_autodevices")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseBarcode)
                    .HasColumnName("use_barcode")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseCams).HasColumnName("use_cams");

                entity.Property(e => e.UseDigitTables).HasColumnName("use_digit_tables");

                entity.Property(e => e.UseRecognOverview).HasColumnName("use_recogn_overview");

                entity.Property(e => e.UseRecognPictures)
                    .HasColumnName("use_recogn_pictures")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseRecognition)
                    .HasColumnName("use_recognition")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseSimpleView)
                    .HasColumnName("use_simple_view")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseVadSensors)
                    .HasColumnName("use_vad_sensors")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseWeightDot)
                    .HasColumnName("use_weight_dot")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseWeightDotAuth)
                    .HasColumnName("use_weight_dot_auth")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.WatchSensorsOnKpp).HasColumnName("watch_sensors_on_kpp");

                entity.HasOne(d => d.ConnectedPostNavigation)
                    .WithOne(p => p.InverseConnectedPostNavigation)
                    .HasForeignKey<Post>(d => d.ConnectedPost)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("posts_connected_post_fkey");

                entity.HasOne(d => d.QrBack)
                    .WithMany(p => p.PostQrBacks)
                    .HasForeignKey(d => d.QrBackId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("qr_back_post_id_fkey");

                entity.HasOne(d => d.Qr)
                    .WithMany(p => p.PostQrs)
                    .HasForeignKey(d => d.QrId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("qr_post_id_fkey");

                entity.HasOne(d => d.RfidBack)
                    .WithMany(p => p.PostRfidBacks)
                    .HasForeignKey(d => d.RfidBackId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("rfid_back_post_id_fkey");

                entity.HasOne(d => d.Rfid)
                    .WithMany(p => p.PostRfids)
                    .HasForeignKey(d => d.RfidId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("rfid_post_id_fkey");

                entity.HasOne(d => d.SensorAutodevice)
                    .WithMany(p => p.PostSensorAutodevices)
                    .HasForeignKey(d => d.SensorAutodeviceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("posts_sensor_autodevice_id_fkey");

                entity.HasOne(d => d.SensorKppAutodevice)
                    .WithMany(p => p.PostSensorKppAutodevices)
                    .HasForeignKey(d => d.SensorKppAutodeviceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("posts_sensor_kpp_autodevice_id_fkey");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("posts_template_id_fkey");
            });

            modelBuilder.Entity<PostsAndUser>(entity =>
            {
                entity.ToTable("posts_and_users");

                entity.HasIndex(e => e.PostId, "posts_and_users_post_id_idx");

                entity.HasIndex(e => e.UserId, "posts_and_users_user_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('p_and_u_id_seq'::regclass)");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostsAndUsers)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("p_and_u_post_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostsAndUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("p_and_u_user_id_fk");
            });

            modelBuilder.Entity<PrintScheme>(entity =>
            {
                entity.ToTable("print_schemes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActCount)
                    .HasColumnName("act_count")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(64)
                    .HasColumnName("schema_name");

                entity.Property(e => e.TnCount)
                    .HasColumnName("tn_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TtnCount)
                    .HasColumnName("ttn_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VgmCount)
                    .HasColumnName("vgm_count")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Qr>(entity =>
            {
                entity.ToTable("qr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComParamsId).HasColumnName("com_params_id");

                entity.Property(e => e.QrName)
                    .HasMaxLength(80)
                    .HasColumnName("qr_name");

                entity.HasOne(d => d.ComParams)
                    .WithMany(p => p.Qrs)
                    .HasForeignKey(d => d.ComParamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("qr_com_params_id_fkey");
            });

            modelBuilder.Entity<QrJournal>(entity =>
            {
                entity.ToTable("qr_journal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Good)
                    .HasMaxLength(64)
                    .HasColumnName("good");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Netto).HasColumnName("netto");

                entity.Property(e => e.Operator)
                    .HasMaxLength(128)
                    .HasColumnName("operator");

                entity.Property(e => e.Recipient)
                    .HasMaxLength(128)
                    .HasColumnName("recipient");

                entity.Property(e => e.Trailer)
                    .HasMaxLength(64)
                    .HasColumnName("trailer");

                entity.Property(e => e.Truck)
                    .HasMaxLength(64)
                    .HasColumnName("truck");

                entity.Property(e => e.WeighDate).HasColumnName("weigh_date");

                entity.Property(e => e.Weight1).HasColumnName("weight_1");

                entity.Property(e => e.Weight2).HasColumnName("weight_2");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.QrJournals)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("qr_journal_journal_fk_id_fkey");
            });

            modelBuilder.Entity<RecAlias>(entity =>
            {
                entity.ToTable("rec_aliases");

                entity.HasIndex(e => e.PostId, "rec_aliases_post_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('rec_alias_id_seq'::regclass)");

                entity.Property(e => e.Alias)
                    .HasMaxLength(128)
                    .HasColumnName("alias");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.RecAliases)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("rec_pic_fk");
            });

            modelBuilder.Entity<RecKpp>(entity =>
            {
                entity.ToTable("rec_kpp");

                entity.HasIndex(e => e.PostId, "rec_kpp_post_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(128)
                    .HasColumnName("alias");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.RecKpps)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("rec_kpp_fk");
            });

            modelBuilder.Entity<RecSetting>(entity =>
            {
                entity.ToTable("rec_settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecHost)
                    .HasMaxLength(128)
                    .HasColumnName("rec_host")
                    .HasDefaultValueSql("'localhost'::character varying");

                entity.Property(e => e.RecPort)
                    .HasColumnName("rec_port")
                    .HasDefaultValueSql("5007");
            });

            modelBuilder.Entity<Reserved>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("pk_reserved_id");

                entity.ToTable("reserved");

                entity.Property(e => e.Value)
                    .HasMaxLength(64)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Rfid>(entity =>
            {
                entity.ToTable("rfid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComParamsId).HasColumnName("com_params_id");

                entity.Property(e => e.IsUhf)
                    .HasColumnName("is_uhf")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RfidName)
                    .HasMaxLength(80)
                    .HasColumnName("rfid_name");

                entity.Property(e => e.UseId)
                    .HasColumnName("use_id")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.ComParams)
                    .WithMany(p => p.Rfids)
                    .HasForeignKey(d => d.ComParamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("rfid_com_params_id_fkey");
            });

            modelBuilder.Entity<Scale>(entity =>
            {
                entity.ToTable("scales");

                entity.HasComment("Весы");

                entity.HasIndex(e => e.PostId, "post_id_uq_id")
                    .IsUnique();

                entity.HasIndex(e => e.ComParamsId, "scales_com_params_id_idx");

                entity.HasIndex(e => e.IpParamsId, "scales_ip_params_id_idx");

                entity.HasIndex(e => e.PostId, "scales_post_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutoZero).HasColumnName("auto_zero");

                entity.Property(e => e.AvionAxlesOnScales).HasColumnName("avion_axles_on_scales");

                entity.Property(e => e.Callback)
                    .HasColumnName("callback")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.CancelCode).HasColumnName("cancel_code");

                entity.Property(e => e.ClientIp)
                    .HasMaxLength(128)
                    .HasColumnName("client_ip")
                    .HasDefaultValueSql("'127.0.0.1'::character varying");

                entity.Property(e => e.ClientPort)
                    .HasColumnName("client_port")
                    .HasDefaultValueSql("9379");

                entity.Property(e => e.ComParamsId).HasColumnName("com_params_id");

                entity.Property(e => e.ComPort)
                    .HasMaxLength(64)
                    .HasColumnName("com_port")
                    .HasDefaultValueSql("'COM1'::character varying");

                entity.Property(e => e.ErrorTicks).HasColumnName("error_ticks");

                entity.Property(e => e.IpParamsId).HasColumnName("ip_params_id");

                entity.Property(e => e.LiquidOffset)
                    .HasColumnName("liquid_offset")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LiquidWeighting)
                    .HasColumnName("liquid_weighting")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.NetAddress)
                    .HasColumnName("net_address")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OnlyClient).HasColumnName("only_client");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.RepeatCode)
                    .HasColumnName("repeat_code")
                    .HasDefaultValueSql("999999");

                entity.Property(e => e.SaveLastCode).HasColumnName("save_last_code");

                entity.Property(e => e.ScalesName)
                    .HasMaxLength(80)
                    .HasColumnName("scales_name");

                entity.Property(e => e.SendConfirm).HasColumnName("send_confirm");

                entity.Property(e => e.ServerPort)
                    .HasColumnName("server_port")
                    .HasDefaultValueSql("9378");

                entity.Property(e => e.StableTimeout).HasColumnName("stable_timeout");

                entity.Property(e => e.Threshold)
                    .HasColumnName("threshold")
                    .HasDefaultValueSql("200");

                entity.Property(e => e.TvText)
                    .HasMaxLength(34)
                    .HasColumnName("tv_text")
                    .HasDefaultValueSql("'KOD:'::character varying");

                entity.Property(e => e.UseNewStable)
                    .HasColumnName("use_new_stable")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.WaitOutAddTime)
                    .HasColumnName("wait_out_add_time")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeighAnimals).HasColumnName("weigh_animals");

                entity.Property(e => e.ZeroBeforeIn).HasColumnName("zero_before_in");

                entity.HasOne(d => d.ComParams)
                    .WithMany(p => p.Scales)
                    .HasForeignKey(d => d.ComParamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("scales_com_params_id_fkey");

                entity.HasOne(d => d.IpParams)
                    .WithMany(p => p.Scales)
                    .HasForeignKey(d => d.IpParamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("scales_ip_params_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithOne(p => p.Scale)
                    .HasForeignKey<Scale>(d => d.PostId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("scales_to_post_fk_id");
            });

            modelBuilder.Entity<Sensor>(entity =>
            {
                entity.ToTable("sensors");

                entity.HasIndex(e => e.AutodeviceId, "sensors_autodevice_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutodeviceId).HasColumnName("autodevice_id");

                entity.Property(e => e.ContactNum).HasColumnName("contact_num");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.HasOne(d => d.Autodevice)
                    .WithMany(p => p.Sensors)
                    .HasForeignKey(d => d.AutodeviceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sensors_autodevice_id_fkey");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sessions");

                entity.Property(e => e.Cookie).HasColumnName("cookie");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("('now'::text)::date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.ToTable("station");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_oosp.uuid_generate_v4()");

                entity.Property(e => e.Accountant)
                    .HasMaxLength(256)
                    .HasColumnName("accountant");

                entity.Property(e => e.ActPath).HasColumnName("act_path");

                entity.Property(e => e.AlwaysUseTareFromCatalog).HasColumnName("always_use_tare_from_catalog");

                entity.Property(e => e.AutoNumReverse)
                    .HasColumnName("auto_num_reverse")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AutoPrint).HasColumnName("auto_print");

                entity.Property(e => e.AutoPrintPs)
                    .HasColumnName("auto_print_ps")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AutoSendPs)
                    .HasColumnName("auto_send_ps")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AutoStart)
                    .HasColumnName("auto_start")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AvionVadPath).HasColumnName("avion_vad_path");

                entity.Property(e => e.BlockDockForUsers)
                    .HasColumnName("block_dock_for_users")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CatchLogAvionVad)
                    .HasColumnName("catch_log_avion_vad")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ChooseTemplate)
                    .HasColumnName("choose_template")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CleverCheck).HasColumnName("clever_check");

                entity.Property(e => e.CloseTransitOnAuto).HasColumnName("close_transit_on_auto");

                entity.Property(e => e.CompanyLabel).HasColumnName("company_label");

                entity.Property(e => e.CompareNums).HasColumnName("compare_nums");

                entity.Property(e => e.Declaration).HasColumnName("declaration");

                entity.Property(e => e.Director)
                    .HasMaxLength(256)
                    .HasColumnName("director");

                entity.Property(e => e.DtDefTextBadAxles)
                    .HasMaxLength(64)
                    .HasColumnName("dt_def_text_bad_axles")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DtDefTextErrorCalc)
                    .HasMaxLength(64)
                    .HasColumnName("dt_def_text_error_calc")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DtDefTextOkAxles)
                    .HasMaxLength(64)
                    .HasColumnName("dt_def_text_ok_axles")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DtDefTextWrongId)
                    .HasMaxLength(64)
                    .HasColumnName("dt_def_text_wrong_id")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DtDefTextWrongWeight)
                    .HasMaxLength(64)
                    .HasColumnName("dt_def_text_wrong_weight")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .HasColumnName("email");

                entity.Property(e => e.ExternFilesUse)
                    .HasColumnName("extern_files_use")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ExternPath).HasColumnName("extern_path");

                entity.Property(e => e.ExternSavePhotos)
                    .HasColumnName("extern_save_photos")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ExternSaveXmlJson)
                    .HasColumnName("extern_save_xml_json")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FactAddres)
                    .HasMaxLength(256)
                    .HasColumnName("fact_addres");

                entity.Property(e => e.ForceReloadScales)
                    .HasColumnName("force_reload_scales")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IgnoreReverseStartIn).HasColumnName("ignore_reverse_start_in");

                entity.Property(e => e.IgnoreReverseWaitOut).HasColumnName("ignore_reverse_wait_out");

                entity.Property(e => e.IgnoreStable)
                    .HasColumnName("ignore_stable")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IgnoreTrailersNums)
                    .IsRequired()
                    .HasColumnName("ignore_trailers_nums")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.KppNums).HasColumnName("kpp_nums");

                entity.Property(e => e.KppWaitTime)
                    .HasColumnName("kpp_wait_time")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.LawAddres)
                    .HasMaxLength(256)
                    .HasColumnName("law_addres");

                entity.Property(e => e.NoAutoWaiting).HasColumnName("no_auto_waiting");

                entity.Property(e => e.NoClearNumAtWait)
                    .HasColumnName("no_clear_num_at_wait")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.NoReverseDates).HasColumnName("no_reverse_dates");

                entity.Property(e => e.NumsToUpper).HasColumnName("nums_to_upper");

                entity.Property(e => e.Organization)
                    .HasMaxLength(256)
                    .HasColumnName("organization");

                entity.Property(e => e.Phone)
                    .HasMaxLength(128)
                    .HasColumnName("phone");

                entity.Property(e => e.PrintAnyWeight).HasColumnName("print_any_weight");

                entity.Property(e => e.PrintCopies)
                    .HasColumnName("print_copies")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PsPort)
                    .HasColumnName("ps_port")
                    .HasDefaultValueSql("55577");

                entity.Property(e => e.PsUrl)
                    .HasMaxLength(128)
                    .HasColumnName("ps_url")
                    .HasDefaultValueSql("'127.0.0.1'::character varying");

                entity.Property(e => e.QrText).HasColumnName("qr_text");

                entity.Property(e => e.QualityPercent)
                    .HasColumnName("quality_percent")
                    .HasDefaultValueSql("80");

                entity.Property(e => e.RecApproachCheck).HasColumnName("rec_approach_check");

                entity.Property(e => e.RecognitionUrl)
                    .HasMaxLength(256)
                    .HasColumnName("recognition_url")
                    .HasDefaultValueSql("'localhost:5007'::character varying");

                entity.Property(e => e.RefreshJournalTime)
                    .HasColumnName("refresh_journal_time")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.ScalesInfo).HasColumnName("scales_info");

                entity.Property(e => e.SearchDaysTill)
                    .HasColumnName("search_days_till")
                    .HasDefaultValueSql("(-1)");

                entity.Property(e => e.SendAnonymousInfo)
                    .HasColumnName("send_anonymous_info")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SensorsDelay)
                    .HasColumnName("sensors_delay")
                    .HasDefaultValueSql("800");

                entity.Property(e => e.TnPath).HasColumnName("tn_path");

                entity.Property(e => e.TransitAlwaysOnTop)
                    .HasColumnName("transit_always_on_top")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.TtnPath).HasColumnName("ttn_path");

                entity.Property(e => e.UseAllPosts).HasColumnName("use_all_posts");

                entity.Property(e => e.UseAvion)
                    .HasColumnName("use_avion")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseBadTransits).HasColumnName("use_bad_transits");

                entity.Property(e => e.UseBetweensFromCatalogs)
                    .HasColumnName("use_betweens_from_catalogs")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseCustomQr)
                    .HasColumnName("use_custom_qr")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseDownhillFromAvion)
                    .HasColumnName("use_downhill_from_avion")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseDownsuspsFromCatalogs).HasColumnName("use_downsusps_from_catalogs");

                entity.Property(e => e.UseKpp).HasColumnName("use_kpp");

                entity.Property(e => e.UseLogs).HasColumnName("use_logs");

                entity.Property(e => e.UseOldTransitView)
                    .HasColumnName("use_old_transit_view")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UsePreview)
                    .HasColumnName("use_preview")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseProtocolQr)
                    .HasColumnName("use_protocol_qr")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseRefreshJournal).HasColumnName("use_refresh_journal");

                entity.Property(e => e.UseRequiredFileds)
                    .IsRequired()
                    .HasColumnName("use_required_fileds")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UseReverseOnDecisions)
                    .HasColumnName("use_reverse_on_decisions")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseReverseStatuses)
                    .IsRequired()
                    .HasColumnName("use_reverse_statuses")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UseSchemes)
                    .HasColumnName("use_schemes")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseTnAutoprint)
                    .HasColumnName("use_tn_autoprint")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseTtnAutoprint)
                    .HasColumnName("use_ttn_autoprint")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.VerifyDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("verify_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.VgmInfo).HasColumnName("vgm_info");

                entity.Property(e => e.VgmPath).HasColumnName("vgm_path");

                entity.Property(e => e.VgmWithAct)
                    .HasColumnName("vgm_with_act")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.WaitInTicks)
                    .HasColumnName("wait_in_ticks")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.WaitPicTime)
                    .HasColumnName("wait_pic_time")
                    .HasDefaultValueSql("1.5");
            });

            modelBuilder.Entity<Tare>(entity =>
            {
                entity.ToTable("tares");

                entity.HasIndex(e => e.ParentId, "tares_parent_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('tares_id_sequense'::regclass)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Isgroup)
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("add_item('Тара '::character varying, 'tares'::character varying)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("currval('tares_id_sequense'::regclass)");

                entity.Property(e => e.TareWeight)
                    .HasColumnName("tare_weight")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("tares_parent_id_fkey");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("tasks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.ExpectedWeight)
                    .HasColumnName("expected_weight")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpectedWeightPercentMes)
                    .HasColumnName("expected_weight_percent_mes")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(64)
                    .HasColumnName("task_name");

                entity.Property(e => e.TaskText)
                    .HasMaxLength(512)
                    .HasColumnName("task_text");

                entity.Property(e => e.UseCustomField)
                    .HasColumnName("use_custom_field")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UseGoodsCatalog)
                    .HasColumnName("use_goods_catalog")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UseTaresCatalog)
                    .HasColumnName("use_tares_catalog")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.CustomField)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.CustomFieldId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tasks_custom_field_fk_id_fkey");

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.GoodId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tasks_good_fk_id_fkey");
            });

            modelBuilder.Entity<TasksAndDriver>(entity =>
            {
                entity.ToTable("tasks_and_drivers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TasksAndDrivers)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("tasks_and_drivers_user_fk_id_fkey");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TasksAndDrivers)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("tasks_and_drivers_task_fk_id_fkey");
            });

            modelBuilder.Entity<TisTable>(entity =>
            {
                entity.ToTable("tis_table", "addons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Finished).HasColumnName("finished");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Rfid)
                    .HasMaxLength(64)
                    .HasColumnName("rfid")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Truck)
                    .HasMaxLength(64)
                    .HasColumnName("truck")
                    .HasDefaultValueSql("''::character varying");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TisTables)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tis_table_journal_fk_id_fkey");
            });

            modelBuilder.Entity<TrafficLight>(entity =>
            {
                entity.ToTable("traffic_lights");

                entity.HasIndex(e => e.AutodeviceId, "traffic_lights_autodevice_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutodeviceId).HasColumnName("autodevice_id");

                entity.Property(e => e.ContactNum).HasColumnName("contact_num");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.HasOne(d => d.Autodevice)
                    .WithMany(p => p.TrafficLights)
                    .HasForeignKey(d => d.AutodeviceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("traffic_lights_autodevice_fk_id");
            });

            modelBuilder.Entity<Trailer>(entity =>
            {
                entity.ToTable("trailers");

                entity.HasComment("Прицепы");

                entity.HasIndex(e => e.ParentId, "trailers_parent_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Isgroup)
                    .IsRequired()
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Mark)
                    .HasMaxLength(64)
                    .HasColumnName("mark");

                entity.Property(e => e.Model)
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("add_item('Прицеп '::character varying, 'trailers'::character varying)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("currval('trailers_id_seq'::regclass)");

                entity.Property(e => e.Type)
                    .HasMaxLength(64)
                    .HasColumnName("type");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_trailers_trailers");
            });

            modelBuilder.Entity<Train>(entity =>
            {
                entity.ToTable("trains");

                entity.HasComment("Вагоны");

                entity.HasIndex(e => e.ParentId, "trains_parent_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvailableMass).HasColumnName("available_mass");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Isgroup)
                    .IsRequired()
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("add_item('Вагон '::character varying, 'trains'::character varying)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("currval('trains_id_seq'::regclass)");

                entity.Property(e => e.Tara).HasColumnName("tara");

                entity.Property(e => e.Type)
                    .HasMaxLength(64)
                    .HasColumnName("type");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_trains_trains");
            });

            modelBuilder.Entity<TroikaTable>(entity =>
            {
                entity.ToTable("troika_table", "addons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brutto).HasColumnName("brutto");

                entity.Property(e => e.BruttoDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("brutto_date");

                entity.Property(e => e.GosNum)
                    .HasMaxLength(64)
                    .HasColumnName("gos_num");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Tare).HasColumnName("tare");

                entity.Property(e => e.TareDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tare_date");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasComment("Пользователи");

                entity.HasIndex(e => e.Login, "uq_login")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CanEdit)
                    .HasColumnName("can_edit")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Fio)
                    .HasMaxLength(128)
                    .HasColumnName("fio");

                entity.Property(e => e.Login)
                    .HasMaxLength(128)
                    .HasColumnName("login");
            });

            modelBuilder.Entity<Vel>(entity =>
            {
                entity.ToTable("vels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Vel1).HasColumnName("vel");

                entity.Property(e => e.Vel2).HasColumnName("vel_2");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Vels)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("vels_journal_id_fkey");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.ToTable("version");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('version_seq_id'::regclass)");

                entity.Property(e => e.Ver)
                    .HasColumnType("character varying")
                    .HasColumnName("ver");
            });

            modelBuilder.Entity<WebUser>(entity =>
            {
                entity.ToTable("web_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(128)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<WeighTime>(entity =>
            {
                entity.ToTable("weigh_time");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.HasSequence("addit_def_vals_id_seq");

            modelBuilder.HasSequence("addit_field_catalog_id_seq");

            modelBuilder.HasSequence("additional_field_id_seq");

            modelBuilder.HasSequence("automatic_device_id_seq");

            modelBuilder.HasSequence("axles_id_seq");

            modelBuilder.HasSequence("between_bru_id_seq");

            modelBuilder.HasSequence("between_id_seq");

            modelBuilder.HasSequence("cams_id_seq");

            modelBuilder.HasSequence("cars_id_seq");

            modelBuilder.HasSequence("companies_id_seq");

            modelBuilder.HasSequence("def_vals_temp_seq_id");

            modelBuilder.HasSequence("default_vals_id_seq");

            modelBuilder.HasSequence("digit_table_id_seq");

            modelBuilder.HasSequence("digit_table_text_id_seq");

            modelBuilder.HasSequence("downsusp_id_seq");

            modelBuilder.HasSequence("drivers_id_seq");

            modelBuilder.HasSequence("gates_id_seq");

            modelBuilder.HasSequence("goods_id_seq");

            modelBuilder.HasSequence("journal_id_seq");

            modelBuilder.HasSequence("logs_id_seq");

            modelBuilder.HasSequence("p_and_u_id_seq");

            modelBuilder.HasSequence("pictures_id_seq");

            modelBuilder.HasSequence("posts_id_seq");

            modelBuilder.HasSequence("rec_alias_id_seq");

            modelBuilder.HasSequence("scales_id_seq");

            modelBuilder.HasSequence("sensors_id_seq");

            modelBuilder.HasSequence("sessions_id_seq");

            modelBuilder.HasSequence("status_autodevice_id_seq");

            modelBuilder.HasSequence("status_digit_table_id_seq");

            modelBuilder.HasSequence("tares_id_sequense");

            modelBuilder.HasSequence("traffic_lights_id_seq");

            modelBuilder.HasSequence("trailers_id_seq");

            modelBuilder.HasSequence("trains_id_seq");

            modelBuilder.HasSequence("users_id_seq");

            modelBuilder.HasSequence("version_seq_id");

            modelBuilder.HasSequence("web_users_id_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
