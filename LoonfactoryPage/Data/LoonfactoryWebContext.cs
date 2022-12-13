using Loonfactory.Acmicpc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoonfactoryPage.Data;

/// <summary>
/// Data context used on the Loonfactory web.
/// </summary>
public class LoonfactoryWebContext : IdentityDbContext
{
    /// <summary>
    /// Initializes a new instance of <see cref="LoonfactoryWebContext"/>.
    /// </summary>
    /// <param name="options">The options to be used by a <see cref="DbContext"/>.</param>
    public LoonfactoryWebContext(DbContextOptions<LoonfactoryWebContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{TEntity}"/> of Acmicpc problem.
    /// </summary>
    public virtual DbSet<AcmicpcProblem> AcmicpcProblems { get; set; } = default!;

    /// <summary>
    /// Gets or sets the <see cref="DbSet{TEntity}"/> of Acmicpc problem publishs.
    /// </summary>
    public virtual DbSet<AcmicpcProblemPublish> AcmicpcProblemPublishs { get; set; } = default!;

    /// <summary>
    /// Gets or sets the <see cref="DbSet{TEntity}"/> of recommend problem.
    /// </summary>
    public virtual DbSet<RecommendProblem> RecommendProblems { get; set; } = default!;

    /// <summary>
    /// Configures the schema needed along with the identity schema.
    /// </summary>
    /// <param name="builder">
    /// The builder being used to construct the model for this context.
    /// </param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.AddAcmicpcSchema();

        builder.Entity<AcmicpcProblem>(b =>
        {
            b.HasOne<RecommendProblem>().WithOne().HasForeignKey<RecommendProblem>(rp => rp.Id);
        });

        builder.Entity<RecommendProblem>(b =>
        {
            b.HasKey(rp => rp.Id);
            b.ToTable("RecommendProblems");
        });
    }
}