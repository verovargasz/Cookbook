using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cookbook.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [Microsoft.Build.Framework.Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Description]
        public string Description { get; set; }
    }
}
