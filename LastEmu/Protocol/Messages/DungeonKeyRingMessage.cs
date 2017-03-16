using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DungeonKeyRingMessage : NetworkMessage
	{
		public const uint Id = 6299;

		public uint[] availables;

		public uint[] unavailables;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6299;
			}
		}

		public DungeonKeyRingMessage()
		{
		}

		public DungeonKeyRingMessage(uint[] availables, uint[] unavailables)
		{
			this.availables = availables;
			this.unavailables = unavailables;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.availables = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.availables[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.unavailables = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.unavailables[j] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.availables.Length));
			uint[] numArray = this.availables;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.unavailables.Length));
			uint[] numArray1 = this.unavailables;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
		}
	}
}