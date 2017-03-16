using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KrosmasterAuthTokenMessage : NetworkMessage
	{
		public const uint Id = 6351;

		public string token;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6351;
			}
		}

		public KrosmasterAuthTokenMessage()
		{
		}

		public KrosmasterAuthTokenMessage(string token)
		{
			this.token = token;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.token = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.token);
		}
	}
}