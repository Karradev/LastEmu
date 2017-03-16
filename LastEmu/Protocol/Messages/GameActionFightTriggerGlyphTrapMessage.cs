using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
	{
		public const uint Id = 5741;

		public short markId;

		public double triggeringCharacterId;

		public uint triggeredSpellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5741;
			}
		}

		public GameActionFightTriggerGlyphTrapMessage()
		{
		}

		public GameActionFightTriggerGlyphTrapMessage(uint actionId, double sourceId, short markId, double triggeringCharacterId, uint triggeredSpellId) : base(actionId, sourceId)
		{
			this.markId = markId;
			this.triggeringCharacterId = triggeringCharacterId;
			this.triggeredSpellId = triggeredSpellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.markId = reader.ReadShort();
			this.triggeringCharacterId = reader.ReadDouble();
			this.triggeredSpellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.markId);
			writer.WriteDouble(this.triggeringCharacterId);
			writer.WriteVarShort((int)this.triggeredSpellId);
		}
	}
}