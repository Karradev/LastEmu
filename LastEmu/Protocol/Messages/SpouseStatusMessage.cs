using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpouseStatusMessage : NetworkMessage
	{
		public const uint Id = 6265;

		public bool hasSpouse;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6265;
			}
		}

		public SpouseStatusMessage()
		{
		}

		public SpouseStatusMessage(bool hasSpouse)
		{
			this.hasSpouse = hasSpouse;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.hasSpouse = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.hasSpouse);
		}
	}
}