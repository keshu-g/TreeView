using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TreeView.Models
{
    public class Node
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Letter { get; set; }

        [Required]
        public TreeType Type { get; set; } = TreeType.ROOT;

        // recurvsive relationship for tree structure
        public int? ParentId { get; set; }

        [JsonIgnore]
        [ForeignKey("ParentId")]
        public Node? Parent { get; set; }

        public ICollection<Node> Children { get; set; } = new List<Node>();
    }

    public enum TreeType
    {
        ROOT = 0,
        CHILD = 1,
    }
}
