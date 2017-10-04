public class Projectile : IDamageble
{
	private float velocity;

	private int blastRadius;

	private Character owner;

	private Explosion explosion;

	private Explosion explosion;

	private Projectile(float velocity, int blastRadius, Character owner)
	{

	}

	public Explosion Explode()
	{
		return null;
	}


	/// <see>IDamageble#OnDestroy()</see>
	/// 
	///  
	public void OnDestroy()
	{

	}

}

