using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Data;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Service;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<Student_College_DbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Database")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RestfulCRUD_APIs_CodingStandard_Validation_DI", Version = "v1" });
            });

            services.AddTransient<IStudent, StudentService>();
            services.AddTransient<ICollege, CollegeService>();
            services.AddTransient<IStudentDA, StudentDA>();
            services.AddTransient<ICollegeDA, CollegeDA>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestfulCRUD_APIs_CodingStandard_Validation_DI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
