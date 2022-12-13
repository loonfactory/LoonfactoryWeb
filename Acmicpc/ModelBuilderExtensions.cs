using Microsoft.EntityFrameworkCore;

namespace Loonfactory.Acmicpc;

public static class ModelBuilderExtensions
{
    public static void AddAcmicpcSchema(this ModelBuilder builder)
    {
        builder.Entity<AcmicpcProblem>(b =>
        {
            b.HasKey(ap => ap.Id);
            b.ToTable("AcmicpcProblems");

            b.HasMany<AcmicpcProblemPublish>().WithOne().HasForeignKey(app => app.ProblemId).IsRequired();
        });

        builder.Entity<AcmicpcProblemPublish>(b =>
        {
            b.HasKey(app => app.PublishNo);
            b.ToTable("AcmicpcProblemPublishs");
            b.Property(app => app.ConcurrencyStamp).IsConcurrencyToken();

            b.Property(app => app.Result).HasConversion<byte>();
        });
    }
}
