using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
	{
		public const uint Id = 6412;

		public sbyte elementEventId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6412;
			}
		}

		public GameContextRemoveElementWithEventMessage()
		{
		}

		public GameContextRemoveElementWithEventMessage(double id, sbyte elementEventId) : base(id)
		{
			this.elementEventId = elementEventId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.elementEventId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.elementEventId);
		}
	}
}