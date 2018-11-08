using System;
namespace prueba33.Models
{
    public class CurriculumVitae
    {
        public int IdPdf { get; set; }
        public int IdCurriculum { get; private set; }

        public CurriculumVitae(int IdPdf)
        {
            this.IdPdf = IdPdf;
        }
    }
}
