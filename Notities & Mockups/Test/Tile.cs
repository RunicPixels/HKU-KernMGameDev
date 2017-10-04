public class Tile : IDamageble
{
	private boolean isDestructable;

	private int state;

	private Vector3 position;

	private Pick-Up pick-Up;

	public Tile(int isDestructable, int state, int position)
	{

	}

	public boolean DropPick-Up(Pick-Up pick-Up)
	{
		return false;
	}


	/// <see>IDamageble#OnDestroy()</see>
	/// 
	///  
	public void OnDestroy()
	{

	}

}

