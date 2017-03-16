using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TitleGainedMessage : NetworkMessage
	{
		public const uint Id = 6364;

		public uint titleId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6364;
			}
		}

		public TitleGainedMessage()
		{
		}

		public TitleGainedMessage(uint titleId)
		{
			this.titleId = titleId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.titleId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.titleId);
		}
	}
}