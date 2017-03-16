using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightUnmarkCellsMessage : AbstractGameActionMessage
	{
		public const uint Id = 5570;

		public short markId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5570;
			}
		}

		public GameActionFightUnmarkCellsMessage()
		{
		}

		public GameActionFightUnmarkCellsMessage(uint actionId, double sourceId, short markId) : base(actionId, sourceId)
		{
			this.markId = markId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.markId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.markId);
		}
	}
}