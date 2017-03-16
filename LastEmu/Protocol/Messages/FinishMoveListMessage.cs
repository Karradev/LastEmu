using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class FinishMoveListMessage : NetworkMessage
	{
		public const uint Id = 6704;

		public FinishMoveInformations[] finishMoves;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6704;
			}
		}

		public FinishMoveListMessage()
		{
		}

		public FinishMoveListMessage(FinishMoveInformations[] finishMoves)
		{
			this.finishMoves = finishMoves;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.finishMoves = new FinishMoveInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.finishMoves[i] = new FinishMoveInformations();
				this.finishMoves[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.finishMoves.Length));
			FinishMoveInformations[] finishMoveInformationsArray = this.finishMoves;
			for (int i = 0; i < (int)finishMoveInformationsArray.Length; i++)
			{
				finishMoveInformationsArray[i].Serialize(writer);
			}
		}
	}
}