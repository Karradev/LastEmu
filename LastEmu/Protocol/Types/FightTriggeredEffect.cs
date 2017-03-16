using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTriggeredEffect : AbstractFightDispellableEffect
	{
		public const short Id = 210;

		public int arg1;

		public int arg2;

		public int arg3;

		public short delay;

		public override short TypeId
		{
			get
			{
				return 210;
			}
		}

		public FightTriggeredEffect()
		{
		}

		public FightTriggeredEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, int arg1, int arg2, int arg3, short delay) : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
		{
			this.arg1 = arg1;
			this.arg2 = arg2;
			this.arg3 = arg3;
			this.delay = delay;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.arg1 = reader.ReadInt();
			this.arg2 = reader.ReadInt();
			this.arg3 = reader.ReadInt();
			this.delay = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.arg1);
			writer.WriteInt(this.arg2);
			writer.WriteInt(this.arg3);
			writer.WriteShort(this.delay);
		}
	}
}