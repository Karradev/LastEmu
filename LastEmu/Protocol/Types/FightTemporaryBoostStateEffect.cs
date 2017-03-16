using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
	{
		public const short Id = 214;

		public short stateId;

		public override short TypeId
		{
			get
			{
				return 214;
			}
		}

		public FightTemporaryBoostStateEffect()
		{
		}

		public FightTemporaryBoostStateEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, short delta, short stateId) : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
		{
			this.stateId = stateId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.stateId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.stateId);
		}
	}
}