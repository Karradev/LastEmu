using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightLeaveMessage : NetworkMessage
	{
		public const uint Id = 721;

		public double charId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)721;
			}
		}

		public GameFightLeaveMessage()
		{
		}

		public GameFightLeaveMessage(double charId)
		{
			this.charId = charId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.charId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.charId);
		}
	}
}