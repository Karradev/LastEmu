using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicWhoAmIRequestMessage : NetworkMessage
	{
		public const uint Id = 5664;

		public bool verbose;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5664;
			}
		}

		public BasicWhoAmIRequestMessage()
		{
		}

		public BasicWhoAmIRequestMessage(bool verbose)
		{
			this.verbose = verbose;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.verbose = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.verbose);
		}
	}
}