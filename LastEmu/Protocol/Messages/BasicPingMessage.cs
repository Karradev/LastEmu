using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicPingMessage : NetworkMessage
	{
		public const uint Id = 182;

		public bool quiet;

		public override uint ProtocolId
		{
			get
			{
				return (uint)182;
			}
		}

		public BasicPingMessage()
		{
		}

		public BasicPingMessage(bool quiet)
		{
			this.quiet = quiet;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.quiet = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.quiet);
		}
	}
}