using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightPlacementPossiblePositionsMessage : NetworkMessage
	{
		public const uint Id = 703;

		public uint[] positionsForChallengers;

		public uint[] positionsForDefenders;

		public sbyte teamNumber;

		public override uint ProtocolId
		{
			get
			{
				return (uint)703;
			}
		}

		public GameFightPlacementPossiblePositionsMessage()
		{
		}

		public GameFightPlacementPossiblePositionsMessage(uint[] positionsForChallengers, uint[] positionsForDefenders, sbyte teamNumber)
		{
			this.positionsForChallengers = positionsForChallengers;
			this.positionsForDefenders = positionsForDefenders;
			this.teamNumber = teamNumber;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.positionsForChallengers = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.positionsForChallengers[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.positionsForDefenders = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.positionsForDefenders[j] = reader.ReadVarUhShort();
			}
			this.teamNumber = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.positionsForChallengers.Length));
			uint[] numArray = this.positionsForChallengers;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.positionsForDefenders.Length));
			uint[] numArray1 = this.positionsForDefenders;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
			writer.WriteSByte(this.teamNumber);
		}
	}
}