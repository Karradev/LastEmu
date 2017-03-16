using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameDataPlayFarmObjectAnimationMessage : NetworkMessage
	{
		public const uint Id = 6026;

		public uint[] cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6026;
			}
		}

		public GameDataPlayFarmObjectAnimationMessage()
		{
		}

		public GameDataPlayFarmObjectAnimationMessage(uint[] cellId)
		{
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.cellId = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.cellId[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.cellId.Length));
			uint[] numArray = this.cellId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}