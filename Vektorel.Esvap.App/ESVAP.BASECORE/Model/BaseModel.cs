using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVAP.BASECORE.Model
{
   public abstract class BaseModel
    {
        public BaseModel()
        {
            Created = DateTime.Now;
            IsActive = true;
        }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        // Nullable
        public DateTime? Updated { get; set; }
    }
}
