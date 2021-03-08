using System.ComponentModel.DataAnnotations;

namespace MudBlazorTemplate.Extended.Database.Models
{
    public class BaseModel
    {
        #region Public Properties

        [Key]
        public int Id { get; set; }

        #endregion Public Properties
    }
}