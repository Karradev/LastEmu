using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectLadder : ObjectEffectCreature
	{
		public const short Id = 81;

		public uint monsterCount;

		public override short TypeId
		{
			get
			{
				return 81;
			}
		}

		public ObjectEffectLadder()
		{
		}

		public ObjectEffectLadder(uint actionId, uint monsterFamilyId, uint monsterCount) : base(actionId, monsterFamilyId)
		{
			this.monsterCount = monsterCount;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.monsterCount = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.monsterCount);
		}
	}
}