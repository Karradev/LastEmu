using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicPongMessage : NetworkMessage
	{
		public const uint Id = 183;

		public bool quiet;

		public override uint ProtocolId
		{
			get
			{
				return (uint)183;
			}
		}

		public BasicPongMessage()
		{
		}

		public BasicPongMessage(bool quiet)
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