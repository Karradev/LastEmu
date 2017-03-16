using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
	{
		public const short Id = 163;

		public EntityLook entityLook;

		public override short TypeId
		{
			get
			{
				return 163;
			}
		}

		public CharacterMinimalPlusLookInformations()
		{
		}

		public CharacterMinimalPlusLookInformations(double id, string name, byte level, EntityLook entityLook) : base(id, name, level)
		{
			this.entityLook = entityLook;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.entityLook = new EntityLook();
			this.entityLook.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.entityLook.Serialize(writer);
		}
	}
}