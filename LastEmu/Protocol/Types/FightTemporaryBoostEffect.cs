using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
	{
		public const short Id = 209;

		public short delta;

		public override short TypeId
		{
			get
			{
				return 209;
			}
		}

		public FightTemporaryBoostEffect()
		{
		}

		public FightTemporaryBoostEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, short delta) : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
		{
			this.delta = delta;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.delta = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.delta);
		}
	}
}