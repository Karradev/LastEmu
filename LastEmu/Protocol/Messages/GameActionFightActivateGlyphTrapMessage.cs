using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightActivateGlyphTrapMessage : AbstractGameActionMessage
	{
		public const uint Id = 6545;

		public short markId;

		public bool active;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6545;
			}
		}

		public GameActionFightActivateGlyphTrapMessage()
		{
		}

		public GameActionFightActivateGlyphTrapMessage(uint actionId, double sourceId, short markId, bool active) : base(actionId, sourceId)
		{
			this.markId = markId;
			this.active = active;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.markId = reader.ReadShort();
			this.active = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.markId);
			writer.WriteBoolean(this.active);
		}
	}
}