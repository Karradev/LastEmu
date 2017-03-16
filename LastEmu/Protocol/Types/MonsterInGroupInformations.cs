using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MonsterInGroupInformations : MonsterInGroupLightInformations
	{
		public const short Id = 144;

		public EntityLook look;

		public override short TypeId
		{
			get
			{
				return 144;
			}
		}

		public MonsterInGroupInformations()
		{
		}

		public MonsterInGroupInformations(int creatureGenericId, sbyte grade, EntityLook look) : base(creatureGenericId, grade)
		{
			this.look = look;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.look = new EntityLook();
			this.look.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.look.Serialize(writer);
		}
	}
}