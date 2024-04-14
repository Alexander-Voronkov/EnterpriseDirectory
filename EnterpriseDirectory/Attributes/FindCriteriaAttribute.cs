namespace EnterpriseDirectory.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class FindCriteriaAttribute : Attribute
{
    public string CriteriaName { get; set; }

    public FindCriteriaAttribute(string criteriaName)
    {
        CriteriaName = criteriaName;
    }
}
