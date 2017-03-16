using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NpcDialogQuestionMessage : NetworkMessage
	{
		public const uint Id = 5617;

		public uint messageId;

		public string[] dialogParams;

		public uint[] visibleReplies;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5617;
			}
		}

		public NpcDialogQuestionMessage()
		{
		}

		public NpcDialogQuestionMessage(uint messageId, string[] dialogParams, uint[] visibleReplies)
		{
			this.messageId = messageId;
			this.dialogParams = dialogParams;
			this.visibleReplies = visibleReplies;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.messageId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.dialogParams = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.dialogParams[i] = reader.ReadUTF();
			}
			num = reader.ReadUShort();
			this.visibleReplies = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.visibleReplies[j] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.messageId);
			writer.WriteShort((short)((int)this.dialogParams.Length));
			string[] strArrays = this.dialogParams;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				writer.WriteUTF(strArrays[i]);
			}
			writer.WriteShort((short)((int)this.visibleReplies.Length));
			uint[] numArray = this.visibleReplies;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteVarShort((int)numArray[j]);
			}
		}
	}
}