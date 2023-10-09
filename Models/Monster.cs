namespace rpg_db.Models;

public class Monster
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public Propertie[]? Properties { get; set; }

    public Attribute[]? Attributes { get; set; }

    public string Description { get; set; }

    public SkillType[]? SkillType { get; set; }
}

public class Propertie
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class Attribute
{
    public string Name { get; set; }
    public string Value { get; set; }
    public string Mod { get; set; }
}

public class SkillType
{
    public string TypeName { get; set; }
    public Skill[] Skills { get; set; }
}

public class Skill
{
    public string Name { get; set; }
    public string Value { get; set; }
}