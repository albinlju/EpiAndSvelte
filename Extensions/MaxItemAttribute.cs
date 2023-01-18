using System.ComponentModel.DataAnnotations;
using EPiServer.Framework.Localization;
/// <summary>    
/// Limit numbers of items of a specific type in ContentArea. This support allowmultiple for restriction of multiple items. 
/// Add [MaxOfItem(typeof(ArticleTeaserBlock), 2)] to a prop-definition limits the number of type ArticleTeaserBlock to two inside the ContentArea;
/// Example of usage:
///   [Display(Name = "Articles")]
///   [MaxOfItem(typeof(ArticleTeaserBlock), 3)]
///   [MaxOfItem(typeof(ProfilePage), 2)]
///   public virtual ContentArea MyProp { get; set; }
/// </summary>  
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class MaxOfItemAttribute : ValidationAttribute
{
    public MaxOfItemAttribute(Type itemType, int itemMax)
    {
        ItemType = itemType;
        ItemMaximum = itemMax;
    }

    private Type ItemType { get; set; }

    private int ItemMaximum { get; set; }

    public override string FormatErrorMessage(string name)
    {
        return $"Too many elements selected in field {name}. Maximum is {ItemMaximum} of type {ItemType.Name}";
    }

    public override bool IsValid(object value)
    {
        return ValidateContentArea(value as ContentArea);
    }

    public override object TypeId { get; } = new object();

    private bool ValidateContentArea(ContentArea contentArea)
    {
        if (contentArea?.Items == null || !contentArea.Items.Any())
            return true;

        int counter = contentArea.FilteredItems.Select(x => x.GetContent()).Count(c => c.GetType().BaseType == ItemType);
        return counter <= ItemMaximum;
    }
}