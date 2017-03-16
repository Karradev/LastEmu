using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameMapMovementMessage : NetworkMessage
	{
		public const uint Id = 951;

		public short[] keyMovements;

		public double actorId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)951;
			}
		}

		public GameMapMovementMessage()
		{
		}

		public GameMapMovementMessage(short[] keyMovements, double actorId)
		{
			this.keyMovements = keyMovements;
			this.actorId = actorId;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.keyMovements = new short[num];
			for (int i = 0; i < num; i++)
			{
				this.keyMovements[i] = reader.ReadShort();
			}
			this.actorId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.keyMovements.Length));
			short[] numArray = this.keyMovements;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteShort(numArray[i]);
			}
			writer.WriteDouble(this.actorId);
		}
	}
}