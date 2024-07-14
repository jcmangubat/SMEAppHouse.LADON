using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class QuestionAnswerConfiguration(string schema = "dbo")
    : EntityConfiguration<QuestionAnswer, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<QuestionAnswer> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.Question, true, FieldLengths.QuestionAnswer.Question);
        entityBuilder.DefineDbField(x => x.AnswerText, true, FieldLengths.QuestionAnswer.AnswerText);
        entityBuilder.DefineDbField(x => x.IsImportant, false);
    }
}

