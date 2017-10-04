public class Character : MonoBehavior, IDamageble
{
	private int lives;

	private int speed;

	private int blastRadius;

	private Projectile projectile;

	private Projectile projectile;

	public boolean Shoot(Projectile projectile)
	{
		return false;
	}

	public void Move()
	{

	}


	/// <see>IDamageble#OnDestroy()</see>
	/// 
	///  
	public void OnDestroy()
	{

	}

}

