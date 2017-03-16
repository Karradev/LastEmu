using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
	{
		public const short Id = 207;

		public uint boostedSpellId;

		public override short TypeId
		{
			get
			{
				return 207;
			}
		}

		public FightTemporarySpellBoostEffect()
		{
		}

		public FightTemporarySpellBoostEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, short delta, uint boostedSpellId) : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
		{
			this.boostedSpellId = boostedSpellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.boostedSpellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.boostedSpellId);
		}
	}
}