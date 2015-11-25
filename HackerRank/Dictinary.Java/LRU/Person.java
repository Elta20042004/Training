package LRU;

public class Person
{
	private int Id;
	public final int getId()
	{
		return Id;
	}
	public final void setId(int value)
	{
		Id = value;
	}
	private String Name;
	public final String getName()
	{
		return Name;
	}
	public final void setName(String value)
	{
		Name = value;
	}

	public Person(int id, String name)
	{
		setId(id);
		setName(name);
	}
}