using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightNewRoundMessage : NetworkMessage
	{
		public const uint Id = 6239;

		public uint roundNumber;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6239;
			}
		}

		public GameFightNewRoundMessage()
		{
		}

		public GameFightNewRoundMessage(uint roundNumber)
		{
			this.roundNumber = roundNumber;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.roundNumber = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.roundNumber);
		}
	}
}