using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MonsterInGroupLightInformations
	{
		public const short Id = 395;

		public int creatureGenericId;

		public sbyte grade;

		public virtual short TypeId
		{
			get
			{
				return 395;
			}
		}

		public MonsterInGroupLightInformations()
		{
		}

		public MonsterInGroupLightInformations(int creatureGenericId, sbyte grade)
		{
			this.creatureGenericId = creatureGenericId;
			this.grade = grade;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.creatureGenericId = reader.ReadInt();
			this.grade = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.creatureGenericId);
			writer.WriteSByte(this.grade);
		}
	}
}