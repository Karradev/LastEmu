using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameMapMovementRequestMessage : NetworkMessage
	{
		public const uint Id = 950;

		public short[] keyMovements;

		public int mapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)950;
			}
		}

		public GameMapMovementRequestMessage()
		{
		}

		public GameMapMovementRequestMessage(short[] keyMovements, int mapId)
		{
			this.keyMovements = keyMovements;
			this.mapId = mapId;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.keyMovements = new short[num];
			for (int i = 0; i < num; i++)
			{
				this.keyMovements[i] = reader.ReadShort();
			}
			this.mapId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.keyMovements.Length));
			short[] numArray = this.keyMovements;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteShort(numArray[i]);
			}
			writer.WriteInt(this.mapId);
		}
	}
}