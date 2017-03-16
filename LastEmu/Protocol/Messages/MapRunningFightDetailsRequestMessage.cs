using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MapRunningFightDetailsRequestMessage : NetworkMessage
	{
		public const uint Id = 5750;

		public int fightId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5750;
			}
		}

		public MapRunningFightDetailsRequestMessage()
		{
		}

		public MapRunningFightDetailsRequestMessage(int fightId)
		{
			this.fightId = fightId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
		}
	}
}