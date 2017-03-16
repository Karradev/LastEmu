using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
	{
		public const uint Id = 6219;

		public double targetId;

		public uint spellId;

		public int @value;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6219;
			}
		}

		public GameActionFightSpellCooldownVariationMessage()
		{
		}

		public GameActionFightSpellCooldownVariationMessage(uint actionId, double sourceId, double targetId, uint spellId, int value) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.spellId = spellId;
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.spellId = reader.ReadVarUhShort();
			this.@value = reader.ReadVarShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteVarShort((int)this.spellId);
			writer.WriteVarShort(this.@value);
		}
	}
}