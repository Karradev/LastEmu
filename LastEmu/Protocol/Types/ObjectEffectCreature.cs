using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectCreature : ObjectEffect
	{
		public const short Id = 71;

		public uint monsterFamilyId;

		public override short TypeId
		{
			get
			{
				return 71;
			}
		}

		public ObjectEffectCreature()
		{
		}

		public ObjectEffectCreature(uint actionId, uint monsterFamilyId) : base(actionId)
		{
			this.monsterFamilyId = monsterFamilyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.monsterFamilyId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.monsterFamilyId);
		}
	}
}