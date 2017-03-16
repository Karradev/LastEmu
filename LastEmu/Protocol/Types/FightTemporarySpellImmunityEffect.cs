using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTemporarySpellImmunityEffect : AbstractFightDispellableEffect
	{
		public const short Id = 366;

		public int immuneSpellId;

		public override short TypeId
		{
			get
			{
				return 366;
			}
		}

		public FightTemporarySpellImmunityEffect()
		{
		}

		public FightTemporarySpellImmunityEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, int immuneSpellId) : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
		{
			this.immuneSpellId = immuneSpellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.immuneSpellId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.immuneSpellId);
		}
	}
}